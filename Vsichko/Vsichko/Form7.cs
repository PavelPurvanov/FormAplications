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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public static int br = 0;
        public static double suma = 0;

        private void Form7_Load(object sender, EventArgs e)
        {

            label2.Text = "1";
            label6.ResetText();
            label8.ResetText();
            br++;
            label2.Text = br.ToString();
        }

        void calc()
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (radioButton1.Checked)
                {
                    label6.Text = (double.Parse(textBox2.Text) - double.Parse(textBox1.Text)).ToString();
                    label8.Text = ((double.Parse(textBox2.Text) - double.Parse(textBox1.Text)) * 0.34).ToString();
                }

                if (radioButton2.Checked)
                {
                    label6.Text = (double.Parse(textBox2.Text) - double.Parse(textBox1.Text)).ToString();
                    label8.Text = ((double.Parse(textBox2.Text) - double.Parse(textBox1.Text)) * 0.44).ToString();
                }

                if (radioButton3.Checked)
                {
                    label6.Text = (double.Parse(textBox2.Text) - double.Parse(textBox1.Text)).ToString();
                    label8.Text = ((double.Parse(textBox2.Text) - double.Parse(textBox1.Text)) * 0.54).ToString();
                }
                suma = suma + double.Parse(label8.Text);
            }

        }

       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calc();
        }


        
        private void новКлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {

            br++;
            label2.Text = br.ToString();
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Обща сума: " + suma);
        }

        








    }
}
