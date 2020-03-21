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
    public partial class Form10_1 : Form
    {
        public Form10_1()
        {
            InitializeComponent();
        }




        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            if (radioButton1.Checked) textBox3.Text = Math.Pow(a + b, 2).ToString();
            if (radioButton2.Checked) textBox3.Text = Math.Pow(a - b, 2).ToString();
            if (radioButton3.Checked) textBox3.Text = ((a + b) * (a - b)).ToString();
            if (radioButton4.Checked) textBox3.Text = Math.Pow(a + b, 3).ToString();
            if (radioButton5.Checked) textBox3.Text = Math.Pow(a - b, 3).ToString();
            if (radioButton6.Checked) textBox3.Text = (Math.Pow(a, 3) + Math.Pow(b, 3)).ToString();
            if (radioButton7.Checked) textBox3.Text = (Math.Pow(a, 3) - Math.Pow(b, 3)).ToString();
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
