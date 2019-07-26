namespace BMICalculator
{
    partial class BMI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Height = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.Label();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Height, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Weight, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Imperial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Metric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.text1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.text2, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 119);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(3, 39);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(134, 39);
            this.Height.TabIndex = 0;
            this.Height.Text = "My Height";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(3, 78);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(134, 41);
            this.Weight.TabIndex = 1;
            this.Weight.Text = "My Weight";
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(3, 3);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(128, 33);
            this.Imperial.TabIndex = 2;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            this.Imperial.CheckedChanged += new System.EventHandler(this.Imperial_CheckedChanged);
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Location = new System.Drawing.Point(143, 3);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(106, 33);
            this.Metric.TabIndex = 3;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            this.Metric.CheckedChanged += new System.EventHandler(this.Metric_CheckedChanged);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(143, 42);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 38);
            this.text1.TabIndex = 4;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(143, 81);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 38);
            this.text2.TabIndex = 5;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(152, 307);
            this.text3.Multiline = true;
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(140, 122);
            this.text3.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(9, 387);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(140, 42);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate BMI";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(160, 223);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(132, 43);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.ThreeButton, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.TwoButton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.OneButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SixButton, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.FiveButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.FourButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.NineButton, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.EightButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.SevenButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ZeroButton, 1, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 183);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(148, 198);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(155, 272);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(137, 29);
            this.progressBar1.TabIndex = 5;
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(52, 150);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(43, 45);
            this.ZeroButton.TabIndex = 0;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(43, 43);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(52, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(43, 43);
            this.EightButton.TabIndex = 2;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(101, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(43, 43);
            this.NineButton.TabIndex = 3;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(3, 52);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(43, 43);
            this.FourButton.TabIndex = 4;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(52, 52);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(43, 43);
            this.FiveButton.TabIndex = 5;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(101, 52);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(43, 43);
            this.SixButton.TabIndex = 6;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(3, 101);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(43, 43);
            this.OneButton.TabIndex = 7;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(52, 101);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(43, 43);
            this.TwoButton.TabIndex = 8;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(101, 101);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(43, 43);
            this.ThreeButton.TabIndex = 9;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            // 
            // BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button ZeroButton;
    }
}

