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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            calc();
        }

        public void calc()
        {
            //PRI PREMESTVANE NA SCROOBAR INFORMACIQTA SE VZIMA V LEIBALITE I SE PRESMQTAT 
            label2.Text = " Width = " + hScrollBar1.Value + " Lenght = " + vScrollBar1.Value + " Area =" + hScrollBar1.Value * vScrollBar1.Value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            calc();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            calc();
        }
    }
       
}
