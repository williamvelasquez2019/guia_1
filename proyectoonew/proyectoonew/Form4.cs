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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int x,n1, suma =0;
            listBox1.Items.Clear();
            n1 = int.Parse(textBox1.Text);
            for (x = 1; x <= n1; x++)
            {
                suma = suma + x;
                if (checkBox1.Checked == true)
                {
                    listBox1.Items.Add("sumando :" + x + " suma parcial :" + suma);
                }
            }

            listBox1.Items.Add("la suma total es de :" + suma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
