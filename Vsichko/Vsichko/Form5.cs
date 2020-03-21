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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        double a, b;
        void calc()
        {


            if (!(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                if (comboBox1.Text == "C")
                {
                    a = double.Parse(textBox1.Text);

                    b = (a * 9) / 5 + 32;


                    textBox2.Text = b.ToString();
                }

                if (comboBox1.Text == "F")
                {
                    a = double.Parse(textBox1.Text);

                    b = (a - 32) * 5 / 9;

                    textBox2.Text = b.ToString();
                }
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("F");
            comboBox1.Items.Add("C");
            comboBox1.SelectedIndex = 0;
        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc();
        }

        
    }
}
