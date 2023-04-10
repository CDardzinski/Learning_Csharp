namespace Owoce_Csharp_roz3_przyklad_StringVariableDemo
{
    partial class Form1
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
            this.SetFirstNameLabel = new System.Windows.Forms.Label();
            this.SetLastNameLabel = new System.Windows.Forms.Label();
            this.ConNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.ShowNameButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetFirstNameLabel
            // 
            this.SetFirstNameLabel.AutoSize = true;
            this.SetFirstNameLabel.Location = new System.Drawing.Point(51, 38);
            this.SetFirstNameLabel.Name = "SetFirstNameLabel";
            this.SetFirstNameLabel.Size = new System.Drawing.Size(55, 13);
            this.SetFirstNameLabel.TabIndex = 0;
            this.SetFirstNameLabel.Text = "Podaj imię";
            // 
            // SetLastNameLabel
            // 
            this.SetLastNameLabel.AutoSize = true;
            this.SetLastNameLabel.Location = new System.Drawing.Point(51, 66);
            this.SetLastNameLabel.Name = "SetLastNameLabel";
            this.SetLastNameLabel.Size = new System.Drawing.Size(81, 13);
            this.SetLastNameLabel.TabIndex = 1;
            this.SetLastNameLabel.Text = "Podaj nazwisko";
            // 
            // ConNameLabel
            // 
            this.ConNameLabel.AutoSize = true;
            this.ConNameLabel.Location = new System.Drawing.Point(51, 140);
            this.ConNameLabel.Name = "ConNameLabel";
            this.ConNameLabel.Size = new System.Drawing.Size(109, 13);
            this.ConNameLabel.TabIndex = 2;
            this.ConNameLabel.Text = "Twoje imię i nazwisko";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(203, 35);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(203, 63);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.LastNameTextBox.TabIndex = 4;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(203, 137);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.ReadOnly = true;
            this.FullNameTextBox.Size = new System.Drawing.Size(137, 20);
            this.FullNameTextBox.TabIndex = 5;
            // 
            // ShowNameButton
            // 
            this.ShowNameButton.Location = new System.Drawing.Point(54, 206);
            this.ShowNameButton.Name = "ShowNameButton";
            this.ShowNameButton.Size = new System.Drawing.Size(137, 23);
            this.ShowNameButton.TabIndex = 6;
            this.ShowNameButton.Text = "Pokaż imię i nazwisko";
            this.ShowNameButton.UseVisualStyleBackColor = true;
            this.ShowNameButton.Click += new System.EventHandler(this.ShowNameButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(203, 206);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(137, 23);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Wyjście";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 283);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ShowNameButton);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.ConNameLabel);
            this.Controls.Add(this.SetLastNameLabel);
            this.Controls.Add(this.SetFirstNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SetFirstNameLabel;
        private System.Windows.Forms.Label SetLastNameLabel;
        private System.Windows.Forms.Label ConNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Button ShowNameButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

