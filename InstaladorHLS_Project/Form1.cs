using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaladorHLS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            string message = "¿Quieres cerrar la aplicación?";
            string title = "Cerrar aplicación.";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
            
        }

        private void btnSAM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BatsAdministrador\SAM.lnk");
        }

        private void btnSAMHLS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BatsAdministrador\SAMHLS.lnk");
        }

        private void btnTrazBio_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BatsAdministrador\Trazbio.lnk");
        }

        private void btnVNC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BatsAdministrador\VNC.lnk");
        }

        private void btnODBC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BatsAdministrador\ODBC-INFORMIX-SDK.4.10.lnk");
        }

        private void btnHojaDi_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\BatsAdministrador\HojaDiaria.lnk");
        }

        
    }
}
