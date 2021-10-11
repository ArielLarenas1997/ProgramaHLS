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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSAM_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // mover pantalla 
        //creamos 3 variables tipo int
        int m, mx, my;

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        { 
            // para dejar de mover el formulario m tiene que ser 0 

            m = 0;

        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            // m tendra valor de 1
            m = 1;
            //activa evento
            mx = e.X;
            // valor actual de la ubicacion del puntero
            my = e.Y;


        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {

            //mientras  se presiona el panel
            if (m ==1)
            { //codigo que permite mover el formulario
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);

            }

        }
    }
}
