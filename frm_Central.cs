using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_2FA
{
    public partial class frm_Central : Form
    {
        public frm_Central()
        {
            InitializeComponent();
        }

        int otp;
        int tempsRestant = 60;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            otp = random.Next(100000, 999999);

            EnviarCorreu();

            lblMissatge.Text = "S'ha enviat el codi per correu electrònic.";

            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            tempsRestant--;

            if (tempsRestant >= 0)
            {
                lblTimer.Text = "           " + tempsRestant.ToString() + "\nsegons restants ...";
            }
            else
            {
                timer1.Stop();
                lblTimer.Text = "Temps esgotat";
            }
        }
    }
}
