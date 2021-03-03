using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurRate
{
    public partial class Form1 : Form
    {
        public double Evro=0;
        public double Rubles = 10000;
        public int day = 0;
        public double rate;
        Random random = new Random();
        public void UpdateUI() {
            RublesValue.Text = ""+Rubles ;
            EvroValue.Text = "" + Evro;
            DayValue.Text = "" + day;
        }

        public Form1()
        {
            InitializeComponent();
        }


        const double k = 0.02;

        private void btCalculate_Click(object sender, EventArgs e)
        {
            

            if (day == 0)
            {
                chart1.Series[0].Points.Clear();
                rate = (double)edRate.Value;
                chart1.Series[0].Points.AddXY(0, rate);
            }
            day++;


            rate = rate * (1 + k * (random.NextDouble() - 0.5));
            chart1.Series[0].Points.AddXY(day, rate);
            UpdateUI();
        }

        private void btnBuyEvro_Click(object sender, EventArgs e)
        {
            if (rate < Rubles)
            {
                Rubles -= rate;
                Evro++;
                UpdateUI();
            }
        }

        private void btnSellEvro_Click(object sender, EventArgs e)
        {
            if (Evro != 0)
            {
                Rubles += rate;
                Evro--;
                UpdateUI();
            }
        }
    }
}
