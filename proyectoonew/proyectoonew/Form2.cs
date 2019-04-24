using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoonew
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String usuario, password;
            usuario = txtLogin.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();
            if ((usuario == "UTEC") && (password == "programacion1")) 
            {
                MessageBox.Show("Bienvenido al sistema");
            }

            else{
                MessageBox.Show("Verifique Usuario y Password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
