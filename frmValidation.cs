using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        SqlConnection conn;
        string cnx = "";
        string query;
        DataSet dts;

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
                cmbDevice.Items.Add(filterInfo.Name);
            cmbDevice.SelectedIndex = 0;
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
                captureDevice.Stop();
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
                        captureDevice.Stop();
                }
            }
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
