namespace Owoce_Csharp_roz4_przyklad4_6
{
    partial class TimeZone
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
            this.PromptLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.CityListBox = new System.Windows.Forms.ListBox();
            this.TimeZoneLabel = new System.Windows.Forms.Label();
            this.OutputDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.Location = new System.Drawing.Point(55, 29);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(232, 13);
            this.PromptLabel.TabIndex = 0;
            this.PromptLabel.Text = "Wybierz miasto, a poznasz jego strefę czasową.";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(58, 282);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(212, 282);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // CityListBox
            // 
            this.CityListBox.FormattingEnabled = true;
            this.CityListBox.Items.AddRange(new object[] {
            "Denver",
            "Honolulu",
            "Minneapolis",
            "Nowy Jork",
            "San Francisco"});
            this.CityListBox.Location = new System.Drawing.Point(58, 62);
            this.CityListBox.Name = "CityListBox";
            this.CityListBox.Size = new System.Drawing.Size(229, 147);
            this.CityListBox.TabIndex = 3;
            // 
            // TimeZoneLabel
            // 
            this.TimeZoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeZoneLabel.Location = new System.Drawing.Point(167, 229);
            this.TimeZoneLabel.Name = "TimeZoneLabel";
            this.TimeZoneLabel.Size = new System.Drawing.Size(120, 28);
            this.TimeZoneLabel.TabIndex = 4;
            this.TimeZoneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OutputDescriptionLabel
            // 
            this.OutputDescriptionLabel.AutoSize = true;
            this.OutputDescriptionLabel.Location = new System.Drawing.Point(55, 237);
            this.OutputDescriptionLabel.Name = "OutputDescriptionLabel";
            this.OutputDescriptionLabel.Size = new System.Drawing.Size(80, 13);
            this.OutputDescriptionLabel.TabIndex = 5;
            this.OutputDescriptionLabel.Text = "Strefa czasowa";
            // 
            // TimeZone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 353);
            this.Controls.Add(this.OutputDescriptionLabel);
            this.Controls.Add(this.TimeZoneLabel);
            this.Controls.Add(this.CityListBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.PromptLabel);
            this.Name = "TimeZone";
            this.Text = "Wime Zone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.ListBox CityListBox;
        private System.Windows.Forms.Label TimeZoneLabel;
        private System.Windows.Forms.Label OutputDescriptionLabel;
    }
}

