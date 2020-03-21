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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;
            c = double.Parse(textBox1.Text);
            if (radioButton1.Checked)
            {

                a = 0.089;
                b = 0;
                label3.Text = "ДОО " + (a * c).ToString() + "лв";
                label4.Text = "ДЗПО " + (b * c).ToString() + "лв";
                label5.Text = "Здравни осигуровки " + (0.032 * c).ToString() + "лв";
                label6.Text = "ОБЩО " + (a * c + b * c + 0.032 * c).ToString() + "лв";

            }
            if (radioButton2.Checked)
            {

                a = 0.067;
                b = 0.022;
                label3.Text = "ДОО " + (a * c).ToString() + "лв";
                label4.Text = "ДЗПО " + (b * c).ToString() + "лв";
                label5.Text = "Здравни осигуровки " + (0.032 * c).ToString() + "лв";
                label6.Text = "ОБЩО " + (a * c + b * c + 0.032 * c).ToString() + "лв";

            }
        }

        //ДА НЕ МОЖЕ ДА СЕ ВЪВЕЖДА РАЗЛИЧНО ОТ ЧИСЛО
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; textBox1.Focus();
            }

        }



    }
}
