using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema4
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            double a, b, c, d, x1, x2;
            try
            {
                a = Double.Parse(textBoxA.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("'A' should be a double number");
                return;
            }
            try
            {
                b = Double.Parse(textBoxB.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("'B' should be a double number");
                return;
            }
            try
            {
                c = Double.Parse(textBoxC.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("'C' should be a double number");
                return;
            }
            d = b * b - 4 * a * c;
            if (d >= 0)
                if (d == 0)

                {
                    x1 = x2 = -b / (2 * a);
                    MessageBox.Show("Solution are " + x1.ToString() +" and "+ x2.ToString());
                }
                else
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    MessageBox.Show("Solutions are" + x1.ToString() + " and " + x2.ToString());
                }
            else
                MessageBox.Show("No solution");
        }
    }
}
