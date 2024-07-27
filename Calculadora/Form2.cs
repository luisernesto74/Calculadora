using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
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
            Form1 formulario1 = new Form1();
            formulario1.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3();
            formulario3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 formulario4 = new Form4();
            formulario4.Show();
        }
    }
}
