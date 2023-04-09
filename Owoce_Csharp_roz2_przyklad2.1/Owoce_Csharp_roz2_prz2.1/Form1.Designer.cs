namespace Owoce_Csharp_roz2_prz2._1
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
            this.firstButton = new System.Windows.Forms.Button();
            this.secondButton = new System.Windows.Forms.Button();
            this.thirdbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(84, 89);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 35);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "Przycisk pierwszy";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // secondButton
            // 
            this.secondButton.Location = new System.Drawing.Point(183, 89);
            this.secondButton.Name = "secondButton";
            this.secondButton.Size = new System.Drawing.Size(75, 35);
            this.secondButton.TabIndex = 1;
            this.secondButton.Text = "Przycisk drugi";
            this.secondButton.UseVisualStyleBackColor = true;
            this.secondButton.Click += new System.EventHandler(this.secondButton_Click);
            // 
            // thirdbutton
            // 
            this.thirdbutton.Location = new System.Drawing.Point(285, 89);
            this.thirdbutton.Name = "thirdbutton";
            this.thirdbutton.Size = new System.Drawing.Size(75, 35);
            this.thirdbutton.TabIndex = 2;
            this.thirdbutton.Text = "Przycisk trzeci";
            this.thirdbutton.UseVisualStyleBackColor = true;
            this.thirdbutton.Click += new System.EventHandler(this.thirdbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 242);
            this.Controls.Add(this.thirdbutton);
            this.Controls.Add(this.secondButton);
            this.Controls.Add(this.firstButton);
            this.Name = "Form1";
            this.Text = "Mój pierwszy program";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button secondButton;
        private System.Windows.Forms.Button thirdbutton;
    }
}

