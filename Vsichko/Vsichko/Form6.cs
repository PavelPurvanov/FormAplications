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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        double[,] k = new double[4, 4]; //MASIV INICIALIZIRANE

        private void Form6_Load(object sender, EventArgs e)
        {
            //slagame tekst v combobox
            comboBox1.Items.Add("feet");
            comboBox1.Items.Add("yards");
            comboBox1.Items.Add("inches");
            comboBox1.Items.Add("miles");
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.Add("feet");
            comboBox2.Items.Add("yards");
            comboBox2.Items.Add("inches");
            comboBox2.Items.Add("miles");
            comboBox2.SelectedIndex = 0;

            //PULNIM MASIV, vsqka 4ast otgovarq na nqkoq merna edinica
            k[0, 0] = 1;
            k[0, 1] = 0.3333;
            k[0, 2] = 1.1989;
            k[0, 3] = 0.0001893;
            
            k[1, 0] = 3;
            k[1, 1] = 1;
            k[1, 2] = 3.5966;
            k[1, 3] = 0.0005682;
            
            k[2, 0] = 0.8341;
            k[2, 1] = 0.278;
            k[2, 2] = 1;
            k[2, 3] = 0.0001579;
            
            k[3, 0] = 1760;
            k[3, 1] = 1760;
            k[3, 2] = 6330;
            k[3, 3] = 1;
        }

        public void calc()
        {
            try
            {
                if (textBox1.Text != "")//AKO IMA NESHTO V TEXBOX DA IZPULNI FORMYLATA
                                                                   //Zadavash na k , na koi indeks da otide
                    textBox2.Text = (double.Parse(textBox1.Text) * k[comboBox1.SelectedIndex, comboBox2.SelectedIndex]).ToString();
            }
            catch { }
        }




        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            calc();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            calc();
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            calc();
        }

    }
}
