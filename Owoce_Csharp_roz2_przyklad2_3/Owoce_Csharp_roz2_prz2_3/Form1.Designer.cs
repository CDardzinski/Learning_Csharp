namespace Owoce_Csharp_roz2_prz2_3
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
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.translationLabel = new System.Windows.Forms.Label();
            this.italianButton = new System.Windows.Forms.Button();
            this.spanishButton = new System.Windows.Forms.Button();
            this.germanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InstructionLabel.Location = new System.Drawing.Point(193, 91);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(386, 18);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Wybierz język, a poznasz powitanie w nim.";
            // 
            // translationLabel
            // 
            this.translationLabel.AutoSize = true;
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.translationLabel.Location = new System.Drawing.Point(54, 148);
            this.translationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 8, 0);
            this.translationLabel.MinimumSize = new System.Drawing.Size(700, 100);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(700, 100);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // italianButton
            // 
            this.italianButton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.italianButton.Location = new System.Drawing.Point(54, 325);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(75, 23);
            this.italianButton.TabIndex = 2;
            this.italianButton.Text = "włoski";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(354, 325);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(75, 23);
            this.spanishButton.TabIndex = 3;
            this.spanishButton.Text = "hiszpański";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // germanButton
            // 
            this.germanButton.Location = new System.Drawing.Point(679, 325);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(75, 23);
            this.germanButton.TabIndex = 4;
            this.germanButton.Text = "niemiecki";
            this.germanButton.UseVisualStyleBackColor = true;
            this.germanButton.Click += new System.EventHandler(this.germanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.InstructionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button italianButton;
        private System.Windows.Forms.Button spanishButton;
        private System.Windows.Forms.Button germanButton;
    }
}

