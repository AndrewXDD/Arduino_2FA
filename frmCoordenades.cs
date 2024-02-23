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

        private void btnClosed_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
