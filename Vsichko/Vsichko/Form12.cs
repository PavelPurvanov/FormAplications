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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //ot FAIL
            //string[] lines = System.IO.File.ReadAllLines("c:\\Toppings.txt");
            //foreach (string str in lines)
            //{ checkedListBox1.Items.Add(str); }

            string[] lines = {"anchovies",
                                "bacon",
                                "mushrooms",
                                "onions",
                                "peppers",
                                "sausage" };
            foreach (string item in lines)
            {
                checkedListBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double size = 0, cheese = 0, sum = 0, dollar = 0;

            if (radioButton1.Checked) { size = 9.25; }
            if (radioButton2.Checked) { size = 11.50;}
            if (radioButton3.Checked) { size = 13.75;}

            string crust = " ";
            if (radioButton4.Checked) { crust = radioButton4.Text; }
            if (radioButton5.Checked) { crust = radioButton5.Text; }

            string ch = " ";
            if (checkBox1.Checked) {  ch = "witch extra cheese ";
                                      cheese = 1.50; }


            string s = "";
            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                s = s + " " + checkedListBox1.Items[indexChecked];
                dollar++;
            }
            //MessageBox.Show("Изборът ви е: " + s + " Общият брой маркирани: " + ch);
            sum = size + cheese + dollar;
            
            richTextBox1.Text = "You ordered a " + crust + " crust pizza " +
                   ch + "and " + dollar + " topping:\n" + s + "\nYour total is " + sum;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



    }
}
