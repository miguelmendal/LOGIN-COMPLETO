using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public object Checkbox { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_nombre.Text == "MIGUEL" & txtbox_contraseña.Text == "1234")
                {
                    MessageBox.Show("BIENVENIDO");
                    Application.Exit();
                }
                else
                    MessageBox.Show("INTENTA NUEVAMENTE");
            }
            catch (Exception x)
            {
                MessageBox.Show("Error " +  x);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
