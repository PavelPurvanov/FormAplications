using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vsichko
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        void calc()
        {
            double a, b, c, d, x1, x2;
            if (!(string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text)
                                                        && string.IsNullOrWhiteSpace(textBox3.Text)))//AKO TEKSTBOX SA PRAZNI
            {
                try
                {
                    //VZIMA TEKSTA OT TEXTBOX
                    a = double.Parse(textBox1.Text);
                    b = double.Parse(textBox2.Text);
                    c = double.Parse(textBox3.Text);
                    d = Math.Pow(b, 2) - 4 * a * c;
                    if (d < 0)
                    {
                        MessageBox.Show("No real root !");
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();
                    }
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    textBox4.Text = x1.ToString();
                    textBox5.Text = x2.ToString();
                }
                catch
                {

                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
