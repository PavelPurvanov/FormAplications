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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A = 0;
            double P, r, l, t;
            P = double.Parse(textBox1.Text);
            r = double.Parse(textBox2.Text);
            l = double.Parse(textBox3.Text);
            t = double.Parse(textBox4.Text);
            A = P * (l + t * r);
            label1.Text = String.Format("{0:F2}", A);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A = 0;
            double P, r, n, t;
            P = double.Parse(textBox1.Text);
            r = double.Parse(textBox2.Text);
            n = double.Parse(textBox3.Text);
            t = double.Parse(textBox4.Text);
            A = P * (Math.Pow((t + r / n), (n * t)));
            label1.Text = String.Format("{0:F2}", A);
        }
    }
}
