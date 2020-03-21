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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            string[] lines = {"DSK",
                                "BNB",
                                "UNICREDIT"};
            foreach (string item in lines)
            {
                checkedListBox1.Items.Add(item);
            }
            comboBox1.Items.Add("Малка лихва");
            comboBox1.Items.Add("Средна лихва ");
            comboBox1.Items.Add("Голяма лихва");
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)// DA NE SE VUVEJDA RAZLI4NO OT 4ISLO
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; textBox1.Focus();
            }
        }

        void calc()
        {
            double[] arr = { 0.5, 3, 7 };



            double a = 0, sum = 0, lihva = 0;
            string izbor = "";
            a = Double.Parse(textBox1.Text);

            if (radioButton1.Checked) { izbor = radioButton1.Text; }
            if (radioButton2.Checked) { izbor = radioButton2.Text; }

            string s = "";
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                s = s + " " + checkedListBox1.Items[indexChecked];
            }

            //if (comboBox1.SelectedIndex == 0) { sum = a * 0.5; }
            //if (comboBox1.SelectedIndex == 1) { sum = a * 3; }
            //if (comboBox1.SelectedIndex == 2) { sum = a * 7; }

            sum = a * arr[comboBox1.SelectedIndex];

            richTextBox1.Text = "Вкарахте сума: " + sum + " от банка " + s + " с лихва " +
                comboBox1.Text + " " + izbor;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc();
        }




    }
}
