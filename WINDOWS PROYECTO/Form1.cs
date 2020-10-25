using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINDOWS_PROYECTO
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

        private void btnpresiona_Click(object sender, EventArgs e)
        {
          

            try //CONTROLAR ERRORES ATRAPAR Y CONTROLAR
            {
                string textodeltexbox = ingresanombre.ToString();
    
                string gracias = (" Ya puedes entrar");
                string mostrar = ("Bienvenido : " + textodeltexbox + gracias);
                lbl_nombre.Text = mostrar;
            }
            catch (Exception x) //AQUI ES DE TAMAÑO EL ERROR
            {

                MessageBox.Show("NUMERO INVALIDO:  " + x);
     
            }

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
