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
    public partial class Splash : Form
    {

        /// <summary>
        /// This code for build the splash timer for 3 seconds and turn to Calculator
        /// </summary>
        private Timer time;

        public Splash()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            time.Stop();
            BMI main = new BMI();
            main.Show();
            this.Hide();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
            time = new Timer();
            time.Interval = 3 * 1000;
            time.Tick += new EventHandler(SplashTimer_Tick);
            time.Start();
        }
    }
}
