using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_2FA
{
    public partial class frmCentral : Form
    {
        public frmCentral()
        {
            InitializeComponent();
        }

        private SerialPort portArduino;
        private Thread filEscolta;
        private int otp;
        private int tempsRestant = 60000;
        private string response = "";

        private void frmCentral_Load(object sender, EventArgs e)
        {
            portArduino = new SerialPort();
            timer1.Interval = 10;

            cmbPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            cmbPorts.Items.AddRange(ports);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbPorts.SelectedItem != null)
            {
                string nomPortSeleccionat = cmbPorts.SelectedItem.ToString();

                while (!portArduino.IsOpen)
                {
                    try
                    {
                        portArduino.PortName = nomPortSeleccionat;
                        portArduino.Open();
                        SerialReceive();

                        lblMissatge.Text = "Connexió a l'Arduino establerta correctament.";
                    }
                    catch (Exception ex)
                    {
                        lblMissatge.Text = "Error al obrir el port serie: " + ex.Message;
                    }
                }
            }
            else
            {
                lblMissatge.Text = "Selecciona un port serie abans d'enviar dades.";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            otp = random.Next(100000, 999999);

            txtOTPCode1.Text = otp.ToString();

            if (portArduino.IsOpen)
            {
                portArduino.WriteLine("inici");
            }

            //EnviarCorreu();

            lblMissatge.Text = "S'ha enviat el codi OPT per correu electrònic.";

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempsRestant -= timer1.Interval;

            if (tempsRestant >= 0)
            {
                int segons = tempsRestant / 1000;
                int milisegons = (tempsRestant % 1000) / 10;
                lblTimer.Text = string.Format("{0:D2} : {1:D2}", segons, milisegons);
            }
            else
            {
                timer1.Stop();
                lblTimer.Text = "NO TIME";
            }
        }

        private void btnVerify2_Click(object sender, EventArgs e)
        {
            frmValidation frm = new frmValidation();
            frm.Show();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReceiveData()
        {
            while (portArduino.IsOpen)
            {
                response = portArduino.ReadLine();
                MostrarInfoTextBox(txtOTPCode2, response.Trim());

                if (response.Trim() == otp.ToString())
                {
                    pictureBoxResultat2.Image = Properties.Resources.correcte;
                    timer1.Stop();
                }
                else
                {
                    pictureBoxResultat2.Image = Properties.Resources.incorrecte;
                }
            }
        }

        private void SerialReceive()
        {
            filEscolta = new Thread(ReceiveData);
            filEscolta.Start();
        }

        private void EnviarCorreu()
        {
            string host = "smtp.gmail.com";
            int port = 587;

            SmtpClient client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential("darkcore.g2@gmail.com", "qewqluzictxdouhq"),
                EnableSsl = true
            };

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("darkcore.g2@gmail.com");
            mail.To.Add("ivan.trilla@sarria.salesians.cat");
            mail.Subject = "Codi d'autenticació de dos factors";

            string body = "Autenticació de Dos Factors\n\n";
            body += "Estimat/Estimada usuari/ària,\n";
            body += "Aquí tens el teu codi d'autenticació de dos factors per a accedir al nostre sistema:\n";
            body += otp + "\n";
            body += "Recorda que aquest codi és vàlid només durant un temps limitat en concret 1 MINUT.\n\n";
            body += "Gràcies per utilitzar el nostre servei.\n";
            body += "Salutacions cordials,\n\n";
            body += "El teu equip de S2AM";

            mail.Body = body;
            client.Send(mail);
        }

        private void MostrarInfoTextBox(TextBox txt, string response)
        {
            if (txt.InvokeRequired)
            {
                txt.Invoke((MethodInvoker)delegate
                {
                    txt.Text = response;
                });
            }
            else
            {
                txt.Text = response;
            }
        }
    }
}
