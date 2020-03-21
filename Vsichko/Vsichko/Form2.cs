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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Calculator Calc = new Calculator();

        public void Calc2(object sender, EventArgs e)
        {
            double val1 = Double.Parse(textBox1.Text);
            double val2 = Double.Parse(textBox2.Text);

            string p = "";
            if (sender is Button)
            {
                p = (sender as Button).Text;
            }
            if (p == "+")
            {
                textBox3.Text = Calc.AddNumbers(val1, val2).ToString();
            }
            else if (p == "-")
            {
                textBox3.Text = Calc.DellNumbers(val1, val2).ToString();
            }
            else if (p == "/")
            {
                textBox3.Text = Calc.HalfNumbers(val1, val2).ToString();
            }
            else
            {
                textBox3.Text = Calc.DoubleNumbers(val1, val2).ToString();
            }
        }
    }
}
