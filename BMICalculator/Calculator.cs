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

        /// <summary>
        /// Give a name for calculate
        /// </summary>
        private float finalBMI;

        public TextBox enterDatatoBox { get; set; }//Set text1 and text2 to clickdown event
        public string outputString { get; set; }




        public float heightValue { get; set; }
        public float weightValue { get; set; }
        public bool decimalExists { get; set; }



        public BMI()
        {
            InitializeComponent();
          
        }




        /// <summary>
        /// Tell user they choose Metric or Imperialn and units
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Imperial_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnit.Text = "Inch";
            WeightUnit.Text = "P";
        }

        private void Metric_CheckedChanged(object sender, EventArgs e)
        {
            HeightUnit.Text = "M";
            WeightUnit.Text = "Kg";
        }



        /// <summary>
        /// give a event to number 0-9 and keyboard button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardButtonClick(object sender, EventArgs e)
        {
            try//if the user does not click down text 1 or 2, it will catch this mistake.
            {
                Button TheButton = sender as Button;
                var tag = TheButton.Tag.ToString();

                int numericValue = 0;
                bool numericResult = int.TryParse(tag, out numericValue);

                //add 0-9 and decimal to text1 and 2
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
                    switch (tag)//each click case with tag
                    {
                        case "calculate"://calculate button in the event
                            CalculateButtonClick();

                            break;

                        case "back":// back button in the event
                            BackButtonClick();
                            break;



                        case "decimal":// decimal button in the event
                            DecimalButtonClick();
                            break;


                        case "reset":// reset button in the event
                            ResetButtonClick();
                            break;
                    }

                    
                }
            }
            catch (Exception ButtonError)
            {
                resultText.Text = "";

            }
        }
        // function for reset case.
        private void ResetButtonClick()
        {
            text1.Clear();
            text2.Clear();
            resultText.Clear();
            outputString = "0";
            heightValue = 0.0f;
            weightValue = 0.0f;
            decimalExists = false;
        }
        // function for decimal case.
        private void DecimalButtonClick()
        {
            if (!decimalExists)// only input one decimal
            {
                outputString += ".";
                decimalExists = true;
            }
        }
        // function for back case.
        private void BackButtonClick()
        {
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
            enterDatatoBox.Text = outputString;//when text1 click down it could be text1, when text2 click down  it could be text2

        }
        
        private void CalculateButtonClick()
        {

            //catch wrong enter data type mistake
            try
            {
                heightValue = float.Parse(text1.Text);
                weightValue = float.Parse(text2.Text);


                //the formular for calculate BMI(imperial//Metric)
                if (Imperial.Checked)
                {
                    finalBMI = weightValue * 703 / (heightValue * heightValue);

                }
                else if (Metric.Checked)
                {
                    finalBMI = weightValue / (heightValue * heightValue);
                }
                ProgressBar.Value = (int)finalBMI;
                //determine the statement for health.
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

            //clean wrong enter show the message in the result of text
            catch
            {
                ResetButtonClick();
                resultText.Text = "Error Enter!!!";
            }
        }
        //set 2 texts to one value, when click down clear the text
        private void HeightDataMouseDown(object sender, MouseEventArgs e)
        {
            enterDatatoBox = text1;
            text1.Clear();
            outputString = "";
        }
        //set 2 texts to one value, when click down clear the text
        private void WeightDataMouseDown(object sender, MouseEventArgs e)
        {
            enterDatatoBox = text2;
            text2.Clear();
            outputString = "";
        }
    }
}
