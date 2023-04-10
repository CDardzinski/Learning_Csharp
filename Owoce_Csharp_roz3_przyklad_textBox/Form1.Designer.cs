namespace Owoce_Csharp_roz3_przyklad_textBox
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SetNameLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.readInputButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(157, 74);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(154, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(157, 113);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(154, 20);
            this.outputTextBox.TabIndex = 1;
            // 
            // SetNameLabel
            // 
            this.SetNameLabel.AutoSize = true;
            this.SetNameLabel.Location = new System.Drawing.Point(47, 77);
            this.SetNameLabel.Name = "SetNameLabel";
            this.SetNameLabel.Size = new System.Drawing.Size(55, 13);
            this.SetNameLabel.TabIndex = 2;
            this.SetNameLabel.Text = "Podaj imię";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(47, 116);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(52, 13);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "Wpisałeś";
            // 
            // readInputButton
            // 
            this.readInputButton.Location = new System.Drawing.Point(50, 179);
            this.readInputButton.Name = "readInputButton";
            this.readInputButton.Size = new System.Drawing.Size(75, 23);
            this.readInputButton.TabIndex = 4;
            this.readInputButton.Text = "Odczytaj dane";
            this.readInputButton.UseVisualStyleBackColor = true;
            this.readInputButton.Click += new System.EventHandler(this.readInputButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(213, 179);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Wyjście";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 257);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.readInputButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.SetNameLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label SetNameLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button readInputButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

