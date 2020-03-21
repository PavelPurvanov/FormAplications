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
    public partial class Form10_2 : Form
    {
        public Form10_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            textBox3.Text = Math.Pow(a, b).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
