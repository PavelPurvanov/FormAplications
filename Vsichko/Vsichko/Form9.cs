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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string sp = "", kurs = "";
            string txt1, txt2, txt3;
            txt1 = textBox1.Text;
            txt2 = textBox2.Text;
            txt3 = textBox3.Text;

            //SMQTA OCENKITE 
            double sum; double v1, v2, v3, v4;
            //VZIMA TEKSTA OT TEXBOX I GO PREYBRAZYVA V DOUBLE
            v1 = Double.Parse(textBox4.Text);
            v2 = Double.Parse(textBox5.Text);
            v3 = Double.Parse(textBox6.Text);
            v4 = Double.Parse(textBox7.Text);
            sum = (v1 + v2 + v3 + v4) / 4;

            if (radioButton1.Checked == true)
            {
                sp = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                sp = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                kurs = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                kurs = radioButton4.Text;
            }
            else if (radioButton5.Checked == true)
            {
                kurs = radioButton5.Text;
            }
            else if (radioButton6.Checked == true)
            {
                kurs = radioButton6.Text;
            }
            //IZVEJDA V GOLEMIQ LEIBAL
            textBox8.Text = "Студентът " + textBox1.Text + " " + textBox2.Text + ", с факултетен № " + textBox3.Text + " от " + kurs + " курс, специалност " + sp + " има среден успех: " + sum;

        }

        private void button2_Click(object sender, EventArgs e)
        //PRI NATISKANE NA 
        //BYTON "OTKAZ" IZTRIVA INFORMACIQTA KOQTO E VUVEDENA
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
        }


    }
}
