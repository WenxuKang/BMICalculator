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
        private float finalBMI;

        public TextBox enterDatatoBox { get; set; }
        public string outputString { get; set; }
        public float heightValue { get; set; }
        public float weightValue { get; set; }
        public bool decimalExists { get; set; }



        public BMI()
        {
            InitializeComponent();
          
        }


        /// <summary>
        /// Reset button function
        /// </summary>
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


        /// <summary>
        /// Tell user they choose Metric or Imperial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnit.Text = "Inches";
            WeightUnit.Text = "Pounds";
        }

        private void Metric_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnit.Text = "Metres";
            WeightUnit.Text = "Kg";
        }

        private void KeyboardButtonClick(object sender, EventArgs e)
        {
            try
            {
                Button TheButton = sender as Button;
                var tag = TheButton.Tag.ToString();

                int numericValue = 0;
                bool numericResult = int.TryParse(tag, out numericValue);
                if (numericResult)
                {
                    if (outputString == "0")
                    {
                        outputString = tag;
                    }
                    else
                    {
                        outputString += tag;
                    }
                    enterDatatoBox.Text = outputString;
                }
                else
                {
                    switch (tag)
                    {
                        case "calculate":
                            try
                            {
                                heightValue = float.Parse(text1.Text);
                                weightValue = float.Parse(text2.Text);

                                if (Imperial.Checked)
                                {
                                    finalBMI = weightValue * 703 / (heightValue * heightValue);

                                }
                                else if (Metric.Checked)
                                {
                                    finalBMI = weightValue / (heightValue * heightValue);
                                }
                                if (finalBMI < 18.5)
                                {

                                    ProgressBar.BackColor = Color.Yellow;
                                    resultText.Text = $"{finalBMI:f2}  You are Underweight!";
                                }
                                else if (finalBMI >= 18.5 && finalBMI <= 24.9)
                                {
                                    ProgressBar.BackColor = Color.Green;
                                    resultText.Text = $"{finalBMI:f2}  You are Normal!";
                                }
                                else if (finalBMI >= 25 && finalBMI <= 29.9)
                                {
                                    ProgressBar.BackColor = Color.Orange;
                                    resultText.Text = $"{finalBMI:f2}  You are Overweight!";
                                }
                                else if (finalBMI >= 30)
                                {
                                    ProgressBar.BackColor = Color.Red;
                                    resultText.Text = $"{finalBMI:f2}  You are Obese!";
                                }


                            }
                            catch
                            {
                               
                                resultText.Text = "Error Enter!!!";
                            }


                            break;

                        case "back":
                            var lastChar = outputString.Substring(outputString.Length - 1);
                            if (lastChar == ".")
                            {
                                decimalExists = false;
                            }
                            outputString = outputString.Remove(outputString.Length - 1);
                            if (outputString.Length == 0)
                            {
                                outputString = "0";
                            }
                            enterDatatoBox.Text = outputString;
                            break;



                        case "decimal":
                            if (!decimalExists)
                            {
                                outputString += ".";
                                decimalExists = true;
                            }
                                break;


                        case "reset":

                            break;
                    }

                    
                }
            }
            catch (Exception ButtonError)
            {
                resultText.Text = "";

            }
        }

        private void HeightDataMouseDown(object sender, MouseEventArgs e)
        {
            enterDatatoBox = text1;
            text1.Clear();
            outputString = "";
        }

        private void WeightDataMouseDown(object sender, MouseEventArgs e)
        {
            enterDatatoBox = text2;
            text2.Clear();
            outputString = "";
        }
    }
}
