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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            double days = 0;
            int d = int.Parse(comboBox1.SelectedItem.ToString());
            int m = int.Parse(comboBox2.SelectedItem.ToString());
            int y = int.Parse(comboBox3.SelectedItem.ToString());
            var nextdate = new DateTime(y, m, d);
            DateTime currentday = DateTime.Now;
            days = (nextdate - currentday).TotalDays + 1;
            label1.Text = days.ToString("0");
            //colors
            int nextday = nextdate.Day;
            int nextmonth = nextdate.Month;


            int day1 = 1;
            int month1 = 1;
            int year1 = 2019;
            int day2 = 3;
            int month2 = 3;
            int day3 = 1;
            int month3 = 5;
            this.BackColor = Color.Blue;
            if (nextday == day1 && nextmonth == month1) { this.BackColor = Color.Red; }
            if (nextday == day2 && nextmonth == month2) { this.BackColor = Color.Red; }
            if (nextday == day3 && nextmonth == month3) { this.BackColor = Color.Red; }
        }


    }
}
