using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);
            double n = n1 + n2;
            if (n1 < 0 && n2 > 0)
            {
                txtout.Text = "(" + txt1.Text + ") + " + txt2.Text + " = " + n.ToString();
            }
            else if (n2 < 0 && n1 > 0)
            {
                txtout.Text = txt1.Text + " + (" + txt2.Text + ") = " + n.ToString();
            }
            else if (n1 < 0 && n2 < 0)
            {
                txtout.Text = "(" + txt1.Text + ") + (" + txt2.Text + ") = " + n.ToString();
            }
            else if (n1 > 0 && n2 > 0)
            {
                txtout.Text = txt1.Text + " + " + txt2.Text + " = " + n.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);

            double n = n1 - n2;

            if (n1 < 0 && n2 > 0)
            {
                txtout.Text = "(" + txt1.Text + ") - " + txt2.Text + " = " + n.ToString();
            }
            else if (n2 < 0 && n1 > 0)
            {
                txtout.Text = txt1.Text + " - (" + txt2.Text + ") = " + n.ToString();
            }
            else if (n1 < 0 && n2 < 0)
            {
                txtout.Text = "(" + txt1.Text + ") - (" + txt2.Text + ") = " + n.ToString();
            }
            else if (n1 > 0 && n2 > 0)
            {
                txtout.Text = txt1.Text + " - " + txt2.Text + " = " + n.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);

            double n = n1 * n2;

            if (n1 < 0 && n2 > 0)
            {
                txtout.Text = "(" + txt1.Text + ") * " + txt2.Text + " = " + n.ToString();
            }
            else if (n2 < 0 && n1 > 0)
            {
                txtout.Text = txt1.Text + " * (" + txt2.Text + ") = " + n.ToString();
            }
            else if (n1 < 0 && n2 < 0)
            {
                txtout.Text = "(" + txt1.Text + ") * (" + txt2.Text + ") = " + n.ToString();
            }
            else if (n1 > 0 && n2 > 0)
            {
                txtout.Text = txt1.Text + " * " + txt2.Text + " = " + n.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);
            double n = (n1 + n2)/2;

            if (n1 < 0 && n2 > 0)
            {
                txtout.Text = "((" + txt1.Text + ") + " + txt2.Text + ")/2 = " + n.ToString();
            }
            else if (n2 < 0 && n1 > 0)
            {
                txtout.Text = "(" + txt1.Text + " + (" + txt2.Text + "))/2 = " + n.ToString();
            }
            else if (n1 < 0 && n2 < 0)
            {
                txtout.Text = "((" + txt1.Text + ") + (" + txt2.Text + "))/2 = " + n.ToString();
            }
            else if (n1 > 0 && n2 > 0)
            {
                txtout.Text = "(" + txt1.Text + " + " + txt2.Text + ")/2 = " + n.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txt1.Text);
            double n2 = Convert.ToDouble(txt2.Text);

            double n = n1 % n2;

            txtout.Text = n.ToString();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            txt1.Text = String.Empty;
            txt2.Text = String.Empty;
            txtout.Text= String.Empty;
        }
    }
}
