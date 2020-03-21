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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        double[,] myarr = new double[2, 5];
        private void Form14_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines("d:\\Artikuli.txt");
            foreach (string str in lines)
            { comboBox1.Items.Add(str); }

            myarr[0, 0] = 2;
            myarr[0, 1] = 3;
            myarr[0, 2] = 5;
            myarr[0, 3] = 1;
            myarr[0, 4] = 7;

            myarr[1, 0] = 9;
            myarr[1, 1] = 3;
            myarr[1, 2] = 2;
            myarr[1, 3] = 1;
            myarr[1, 4] = 6;
        }

        void calc()
        {

            double broi = Double.Parse(textBox1.Text);
            double sum = 0;
            double dds = 0.5;

            sum = broi * myarr[comboBox1.SelectedIndex, checkedListBox1.SelectedIndex] + dds;

            textBox2.Text = sum.ToString();
        }

        void calc2()
        {

            double broi = Double.Parse(textBox1.Text);
            string s = "";
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                s = s + " " + checkedListBox1.Items[indexChecked];
            }
            listBox1.Items.Add("Вие закупихте " + s + ", количество " + broi);


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string[] lines = System.IO.File.ReadAllLines("d:\\Plodove.txt");
                foreach (string str in lines)
                { checkedListBox1.Items.Add(str); }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                string[] lines = System.IO.File.ReadAllLines("d:\\Zelenchyci.txt");
                foreach (string str in lines)
                { checkedListBox1.Items.Add(str); }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calc();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calc2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(0);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true; textBox1.Focus();
            }
        }

    }
}
