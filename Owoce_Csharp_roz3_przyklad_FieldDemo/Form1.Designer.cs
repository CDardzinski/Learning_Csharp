namespace Owoce_Csharp_roz3_przyklad_FieldDemo
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
            this.ShowNameButton = new System.Windows.Forms.Button();
            this.ChrisButton = new System.Windows.Forms.Button();
            this.CarmenButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowNameButton
            // 
            this.ShowNameButton.Location = new System.Drawing.Point(108, 28);
            this.ShowNameButton.Name = "ShowNameButton";
            this.ShowNameButton.Size = new System.Drawing.Size(141, 46);
            this.ShowNameButton.TabIndex = 0;
            this.ShowNameButton.Text = "Wyświetl Imię";
            this.ShowNameButton.UseVisualStyleBackColor = true;
            this.ShowNameButton.Click += new System.EventHandler(this.ShowNameButton_Click);
            // 
            // ChrisButton
            // 
            this.ChrisButton.Location = new System.Drawing.Point(12, 80);
            this.ChrisButton.Name = "ChrisButton";
            this.ChrisButton.Size = new System.Drawing.Size(141, 46);
            this.ChrisButton.TabIndex = 1;
            this.ChrisButton.Text = "Zmień imię na Krzysztof";
            this.ChrisButton.UseVisualStyleBackColor = true;
            this.ChrisButton.Click += new System.EventHandler(this.ChrisButton_Click);
            // 
            // CarmenButton
            // 
            this.CarmenButton.Location = new System.Drawing.Point(207, 80);
            this.CarmenButton.Name = "CarmenButton";
            this.CarmenButton.Size = new System.Drawing.Size(141, 46);
            this.CarmenButton.TabIndex = 2;
            this.CarmenButton.Text = "Zmień imię na Katarzyna";
            this.CarmenButton.UseVisualStyleBackColor = true;
            this.CarmenButton.Click += new System.EventHandler(this.CarmenButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(108, 194);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(141, 24);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Wyjście";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 230);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.CarmenButton);
            this.Controls.Add(this.ChrisButton);
            this.Controls.Add(this.ShowNameButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowNameButton;
        private System.Windows.Forms.Button ChrisButton;
        private System.Windows.Forms.Button CarmenButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

