namespace Owoce_Csharp_roz3_przyklad3_1
{
    partial class BirthDateStringPanel
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
            this.DayOfWeekPromptLabel = new System.Windows.Forms.Label();
            this.monthPrompthLabel = new System.Windows.Forms.Label();
            this.DayOfMonthPromptLabel = new System.Windows.Forms.Label();
            this.YearPromptLabel = new System.Windows.Forms.Label();
            this.DayOfWeekTextBox = new System.Windows.Forms.TextBox();
            this.MonthTextBox = new System.Windows.Forms.TextBox();
            this.DayOfMonthTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.DateOutputLabel = new System.Windows.Forms.Label();
            this.ShowDateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DayOfWeekPromptLabel
            // 
            this.DayOfWeekPromptLabel.AutoSize = true;
            this.DayOfWeekPromptLabel.Location = new System.Drawing.Point(63, 45);
            this.DayOfWeekPromptLabel.Name = "DayOfWeekPromptLabel";
            this.DayOfWeekPromptLabel.Size = new System.Drawing.Size(105, 13);
            this.DayOfWeekPromptLabel.TabIndex = 0;
            this.DayOfWeekPromptLabel.Text = "Podaj dzień tygodnia";
            // 
            // monthPrompthLabel
            // 
            this.monthPrompthLabel.AutoSize = true;
            this.monthPrompthLabel.Location = new System.Drawing.Point(56, 90);
            this.monthPrompthLabel.Name = "monthPrompthLabel";
            this.monthPrompthLabel.Size = new System.Drawing.Size(112, 13);
            this.monthPrompthLabel.TabIndex = 1;
            this.monthPrompthLabel.Text = "Podaj nazwę miesiąca";
            // 
            // DayOfMonthPromptLabel
            // 
            this.DayOfMonthPromptLabel.AutoSize = true;
            this.DayOfMonthPromptLabel.Location = new System.Drawing.Point(62, 138);
            this.DayOfMonthPromptLabel.Name = "DayOfMonthPromptLabel";
            this.DayOfMonthPromptLabel.Size = new System.Drawing.Size(106, 13);
            this.DayOfMonthPromptLabel.TabIndex = 2;
            this.DayOfMonthPromptLabel.Text = "Podaj dzień miesiąca";
            // 
            // YearPromptLabel
            // 
            this.YearPromptLabel.AutoSize = true;
            this.YearPromptLabel.Location = new System.Drawing.Point(116, 187);
            this.YearPromptLabel.Name = "YearPromptLabel";
            this.YearPromptLabel.Size = new System.Drawing.Size(52, 13);
            this.YearPromptLabel.TabIndex = 3;
            this.YearPromptLabel.Text = "Podaj rok";
            // 
            // DayOfWeekTextBox
            // 
            this.DayOfWeekTextBox.Location = new System.Drawing.Point(241, 42);
            this.DayOfWeekTextBox.Name = "DayOfWeekTextBox";
            this.DayOfWeekTextBox.Size = new System.Drawing.Size(138, 20);
            this.DayOfWeekTextBox.TabIndex = 4;
            // 
            // MonthTextBox
            // 
            this.MonthTextBox.Location = new System.Drawing.Point(241, 87);
            this.MonthTextBox.Name = "MonthTextBox";
            this.MonthTextBox.Size = new System.Drawing.Size(138, 20);
            this.MonthTextBox.TabIndex = 5;
            // 
            // DayOfMonthTextBox
            // 
            this.DayOfMonthTextBox.Location = new System.Drawing.Point(241, 135);
            this.DayOfMonthTextBox.Name = "DayOfMonthTextBox";
            this.DayOfMonthTextBox.Size = new System.Drawing.Size(138, 20);
            this.DayOfMonthTextBox.TabIndex = 6;
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(241, 184);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(138, 20);
            this.YearTextBox.TabIndex = 7;
            // 
            // DateOutputLabel
            // 
            this.DateOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DateOutputLabel.Location = new System.Drawing.Point(59, 235);
            this.DateOutputLabel.Name = "DateOutputLabel";
            this.DateOutputLabel.Size = new System.Drawing.Size(320, 51);
            this.DateOutputLabel.TabIndex = 8;
            this.DateOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowDateButton
            // 
            this.ShowDateButton.Location = new System.Drawing.Point(59, 322);
            this.ShowDateButton.Name = "ShowDateButton";
            this.ShowDateButton.Size = new System.Drawing.Size(75, 23);
            this.ShowDateButton.TabIndex = 9;
            this.ShowDateButton.Text = "Pokaż datę";
            this.ShowDateButton.UseVisualStyleBackColor = true;
            this.ShowDateButton.Click += new System.EventHandler(this.ShowDateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(177, 322);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Wyczyść";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(304, 322);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 11;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // BirthDateStringPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 400);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ShowDateButton);
            this.Controls.Add(this.DateOutputLabel);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.DayOfMonthTextBox);
            this.Controls.Add(this.MonthTextBox);
            this.Controls.Add(this.DayOfWeekTextBox);
            this.Controls.Add(this.YearPromptLabel);
            this.Controls.Add(this.DayOfMonthPromptLabel);
            this.Controls.Add(this.monthPrompthLabel);
            this.Controls.Add(this.DayOfWeekPromptLabel);
            this.Name = "BirthDateStringPanel";
            this.Text = "Birth Date String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DayOfWeekPromptLabel;
        private System.Windows.Forms.Label monthPrompthLabel;
        private System.Windows.Forms.Label DayOfMonthPromptLabel;
        private System.Windows.Forms.Label YearPromptLabel;
        private System.Windows.Forms.TextBox DayOfWeekTextBox;
        private System.Windows.Forms.TextBox MonthTextBox;
        private System.Windows.Forms.TextBox DayOfMonthTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.Label DateOutputLabel;
        private System.Windows.Forms.Button ShowDateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

