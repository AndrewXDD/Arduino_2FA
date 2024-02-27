using System;
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
        private string cnx = "";
        private DataSet dts;

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

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Users WHERE CodeUser = '" + txtCodiUsuari.Text + "'";

                dts = PortarPerConsulta(query, "Users");

                if (dts.Tables[0].Rows != null)
                {
                    string nomComplet = dts.Tables[0].Rows[0]["UserName"].ToString();
                    string codeUser = dts.Tables[0].Rows[0]["CodeUser"].ToString();
                    string login = dts.Tables[0].Rows[0]["Login"].ToString();

                    txtNomCompletUsuari.Text = nomComplet;
                    txtSequenceCode.Text = codeUser + "\r\n" + nomComplet + "\r\n" + login;
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
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txtSequenceCode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);

            pictureBoxCamera.Image = code.GetGraphic(5);
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
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
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
                    Thread.Sleep(2000);
                    timer1.Stop();

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();

                        if (txtSequenceCode.Text == txtQRCode.Text)
                        {
                            this.Close();

                            frmCoordenades frm = new frmCoordenades();
                            frm.Show();
                        }
                    }
                }
            }
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
