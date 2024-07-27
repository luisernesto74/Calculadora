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
    public partial class Form4 : Form
    {
        private bool drawing = false;
        private Point previousPoint;
        private Color currentColor = Color.Black;
        
        public Form4()
        {
            InitializeComponent();
            panel1.BackColor = Color.White;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_click(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            previousPoint = e.Location;
    }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                if (drawing)
                {
                    using (Graphics g = panel1.CreateGraphics())
                    {
                        g.DrawLine(new Pen(currentColor, 2), previousPoint, e.Location);
                        previousPoint = e.Location;
                    }
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog.Color; // Cambia el color de fondo del panel
            }
        }
    }
}
