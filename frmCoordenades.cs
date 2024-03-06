using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_2FA
{
    public partial class frmCoordenades : Form
    {
        public frmCoordenades()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> coordenades = new Dictionary<string, int>();

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            HashSet<string> hsList = new HashSet<string>();
            int otp;
            string sotp;

            while (hsList.Count < 20)
            {
                Random random = new Random();
                otp = random.Next(1, 9999);
                sotp = otp.ToString();

                while (sotp.Length < 4)
                {
                    sotp = "0" + sotp;
                }
                hsList.Add(sotp);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
