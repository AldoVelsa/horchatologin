using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorchatoLogin
{
    public partial class Form1 : Form
    {
        static int intentos = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nesecitamos el usuario y la contrasena
            //usuario = "horchato" contraseña = "velsa123"
            //solo tiene derecho a 3 intentos
            string usuario = txbxusuario.Text;
            string password = txbxcontra.Text;
            if (this.txbxusuario.Text == "horchato" && this.txbxcontra.Text == "velsa123")
            {
                intentos = 0;
                pictureBox1.Image = new Bitmap(@"C:\Users\aldoy\source\repos\HorchatoLogin\horchato");
                MessageBox.Show("Bienvenido");

            }
            else if (intentos >0 && intentos <=3)
            {
                //avisar cuanto intentos le quedan 
                avisos.Text = "solo tienes" + Convert.ToString(intentos) + " intentos mas ";
                intentos--;
            }
            else
            {
                MessageBox.Show("usuario o contraseña incorrecta");
                intentos++;
                Application.Exit();
            }
        }

        private void avisos_Click(object sender, EventArgs e)
        {

        }
    }
}
