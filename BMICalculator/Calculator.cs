using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class BMI : Form
    {
        public void reset()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Clear();
                }
            }

            foreach (Control y in this.Controls)
            {
                if (y is CheckBox)
                {
                    ((CheckBox)y).Checked = false;
                }
            }
        }
        public BMI()
        {
            InitializeComponent();
        }

        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            text1.Text = "Inches";
            text2.Text = "Pounds";
        }

        private void Metric_CheckedChanged(object sender, EventArgs e)
        {
            text1.Text = "Metres";
            text2.Text = "Kg";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            decimal myHeight;
            decimal myWeight;
            decimal finalBMI = 0;
            myHeight = decimal.Parse(text1.Text);
            myWeight = decimal.Parse(text2.Text);
            if (Imperial.Checked)
            {
                finalBMI = (myWeight * 785) / (myHeight * myHeight);
            }
            else if (Metric.Checked)
            {
                finalBMI = myWeight / (myHeight * myHeight);
            }

            if (finalBMI < 18.5M)
            {
                text3.Text = "your BMI:" + finalBMI + "  You are Underweight!";
            }
            else if (finalBMI >= 18.5M && finalBMI <= 24.9M)
            {
                text3.Text = "your BMI:" + finalBMI + "  You are Normal!";
            }
            else if (finalBMI >= 25M && finalBMI <= 29.9M)
            {
                text3.Text = "your BMI:" + finalBMI + "  You are Overweight!";
            }
            else if (finalBMI >= 30M)
            {
                text3.Text = "your BMI:" + finalBMI + "  You are Obese!";
            }
        }


        private void resetButton_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
