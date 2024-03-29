﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;
using ZXing;

namespace Arduino_2FA
{
    public partial class frmValidation : Form
    {
        public frmValidation()
        {
            InitializeComponent();
        }

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;
        private SqlConnection conn;
        private DataSet dts;
        private DataSet dts2;
        private DataSet dts3;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private string cnx = "";
        private string idUsuari;
        private string dadesBBDD;

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                lblMissatge.Text = "";

                string query = "SELECT * FROM Users WHERE codeUser = '" + txtCodiUsuari.Text + "'";

                dts = PortarPerConsulta(query, "Users");

                if (dts.Tables[0].Rows.Count > 0)
                {
                    idUsuari = dts.Tables[0].Rows[0]["idUser"].ToString();
                    string nomComplet = dts.Tables[0].Rows[0]["descUser"].ToString();
                    txtNomCompletUsuari.Text = nomComplet;

                    string query2 = "SELECT * FROM CodeChain WHERE idUser = '" + idUsuari + "'";
                    dts2 = PortarPerConsulta(query2, "CodeChain");

                    if (dts2.Tables[0].Rows.Count > 0)
                    {
                        dadesBBDD = dts2.Tables[0].Rows[0]["CodeChain"].ToString();
                        txtSequenceCode.Text = dadesBBDD;
                    }
                    else
                    {
                        lblMissatge.Text = "No s'han trobat dades per a aquest usuari.";
                        txtSequenceCode.Text = "";
                    }
                }
                else
                {
                    lblMissatge.Text = "No s'ha trobat cap usuari amb aquest codi.";
                    txtNomCompletUsuari.Text = "";
                    txtSequenceCode.Text = "";
                }
            }
            catch (Exception ex)
            {
                lblMissatge.Text = "Error en mostrar la informació de l'usuari: " + ex.Message;
                txtNomCompletUsuari.Text = "";
                txtSequenceCode.Text = "";
            }
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            try
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(txtSequenceCode.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);

                pictureBoxCamera.Image = code.GetGraphic(5);

                GuardarDadesEnBD(txtSequenceCode.Text);
            }
            catch (Exception ex)
            {
                lblMissatge.Text = ex.Message;
            }
        }

        private void frmValidation_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cmbDevice.Items.Add(filterInfo.Name);
                cmbDevice.SelectedIndex = 0;
            }
        }

        private void btn_CheckQR_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cmbDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void frmValidation_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (captureDevice != null && captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
            }
            catch (Exception ex)
            {
                lblMissatge.Text = ex.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                BarcodeReader barCodeReader = new BarcodeReader();
                Result result = barCodeReader.Decode((Bitmap)pictureBoxCamera.Image);

                if (result != null)
                {
                    txtQRCode.Text = result.ToString();
                    timer1.Stop();

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();

                        if (dadesBBDD == txtQRCode.Text)
                        {
                            frmCoordenades frm = new frmCoordenades();
                            frm.Show();
                        }
                        else
                        {
                            lblMissatge.Text = "Els missatges no coincideixen. Si us plau, escaneja el codi QR correcte.";
                        }
                    }
                }
            }
        }

        public void Connectar()
        {
            ConnectionStringSettings conf = ConfigurationManager.ConnectionStrings["ConnexioBD"];
            if (conf != null) cnx = conf.ConnectionString;

            conn = new SqlConnection(cnx);
        }

        public DataSet PortarPerConsulta(string query, string nomTaulaDades)
        {
            Connectar();
            dts = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

            conn.Open();
            adapter.Fill(dts, nomTaulaDades);
            conn.Close();

            return dts;
        }

        public void Executar(string query)
        {
            Connectar();
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Actualitzar(string query, DataSet modifiedDataSet)
        {
            Connectar();

            adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder cmdBuilder;
            cmdBuilder = new SqlCommandBuilder(adapter);

            if (modifiedDataSet.HasChanges())
            {
                int result = adapter.Update(modifiedDataSet.Tables[0]);
            }

            conn.Close();
        }

        private void GuardarDadesEnBD(string dades)
        {
            try
            {
                string query = "SELECT * FROM CodeChain WHERE idUser = " + idUsuari;
                dts3 = PortarPerConsulta(query, "CodeChain");
                int registres = dts3.Tables[0].Rows.Count;

                //cmd = new SqlCommand(query, conn);
                //conn.Open();
                //int count = (int)cmd.ExecuteScalar();
                //conn.Close();

                if (registres > 0)
                {
                    string queryUpdate = "UPDATE CodeChain SET CodeChain = '" + dades + "' WHERE idUser = " + idUsuari;
                    dts3 = PortarPerConsulta(queryUpdate, "CodeChain");

                    Actualitzar(queryUpdate, dts3);
                }
                else
                {
                    string queryInsert = "INSERT INTO CodeChain (idUser, CodeChain) VALUES (" + idUsuari + ", '" + dades + "')";
                    dts3 = PortarPerConsulta(queryInsert, "CodeChain");
                    Actualitzar(queryInsert, dts3);
                }
            }
            catch (Exception ex)
            {
                lblMissatge.Text = "Error en desar les dades a la base de dades: " + ex.Message;
            }
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
