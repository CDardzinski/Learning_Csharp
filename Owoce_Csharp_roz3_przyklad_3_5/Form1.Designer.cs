namespace Owoce_Csharp_roz3_przyklad_3_5
{
    partial class ChangeCounterPanel
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
            this.FiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.TenCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.TwentyFiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.FiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.OutputDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyFiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyCentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.AutoSize = true;
            this.InstructionLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.InstructionLabel.Location = new System.Drawing.Point(133, 18);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(87, 13);
            this.InstructionLabel.TabIndex = 0;
            this.InstructionLabel.Text = "Kliknij na monetę";
            // 
            // FiveCentsPictureBox
            // 
            this.FiveCentsPictureBox.Image = global::Owoce_Csharp_roz3_przyklad_3_5.Properties.Resources._5cents;
            this.FiveCentsPictureBox.Location = new System.Drawing.Point(44, 48);
            this.FiveCentsPictureBox.Name = "FiveCentsPictureBox";
            this.FiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.FiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FiveCentsPictureBox.TabIndex = 1;
            this.FiveCentsPictureBox.TabStop = false;
            this.FiveCentsPictureBox.Click += new System.EventHandler(this.FiveCentsPictureBox_Click);
            // 
            // TenCentsPictureBox
            // 
            this.TenCentsPictureBox.Image = global::Owoce_Csharp_roz3_przyklad_3_5.Properties.Resources._10cents;
            this.TenCentsPictureBox.Location = new System.Drawing.Point(184, 48);
            this.TenCentsPictureBox.Name = "TenCentsPictureBox";
            this.TenCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.TenCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TenCentsPictureBox.TabIndex = 2;
            this.TenCentsPictureBox.TabStop = false;
            this.TenCentsPictureBox.Click += new System.EventHandler(this.TenCentsPictureBox_Click);
            // 
            // TwentyFiveCentsPictureBox
            // 
            this.TwentyFiveCentsPictureBox.Image = global::Owoce_Csharp_roz3_przyklad_3_5.Properties.Resources._25cents;
            this.TwentyFiveCentsPictureBox.Location = new System.Drawing.Point(44, 254);
            this.TwentyFiveCentsPictureBox.Name = "TwentyFiveCentsPictureBox";
            this.TwentyFiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.TwentyFiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TwentyFiveCentsPictureBox.TabIndex = 3;
            this.TwentyFiveCentsPictureBox.TabStop = false;
            this.TwentyFiveCentsPictureBox.Click += new System.EventHandler(this.TwentyFiveCentsPictureBox_Click);
            // 
            // FiftyCentsPictureBox
            // 
            this.FiftyCentsPictureBox.Image = global::Owoce_Csharp_roz3_przyklad_3_5.Properties.Resources._50cents;
            this.FiftyCentsPictureBox.Location = new System.Drawing.Point(184, 254);
            this.FiftyCentsPictureBox.Name = "FiftyCentsPictureBox";
            this.FiftyCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.FiftyCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FiftyCentsPictureBox.TabIndex = 4;
            this.FiftyCentsPictureBox.TabStop = false;
            this.FiftyCentsPictureBox.Click += new System.EventHandler(this.FiftyCentsPictureBox_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuitButton.Location = new System.Drawing.Point(234, 457);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 5;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(336, 254);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 6;
            // 
            // OutputDescriptionLabel
            // 
            this.OutputDescriptionLabel.AutoSize = true;
            this.OutputDescriptionLabel.Location = new System.Drawing.Point(369, 216);
            this.OutputDescriptionLabel.Name = "OutputDescriptionLabel";
            this.OutputDescriptionLabel.Size = new System.Drawing.Size(40, 13);
            this.OutputDescriptionLabel.TabIndex = 7;
            this.OutputDescriptionLabel.Text = "Razem";
            // 
            // ChangeCounterPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.QuitButton;
            this.ClientSize = new System.Drawing.Size(476, 504);
            this.Controls.Add(this.OutputDescriptionLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.FiftyCentsPictureBox);
            this.Controls.Add(this.TwentyFiveCentsPictureBox);
            this.Controls.Add(this.TenCentsPictureBox);
            this.Controls.Add(this.FiveCentsPictureBox);
            this.Controls.Add(this.InstructionLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ChangeCounterPanel";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.FiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwentyFiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FiftyCentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel;
        private System.Windows.Forms.PictureBox FiveCentsPictureBox;
        private System.Windows.Forms.PictureBox TenCentsPictureBox;
        private System.Windows.Forms.PictureBox TwentyFiveCentsPictureBox;
        private System.Windows.Forms.PictureBox FiftyCentsPictureBox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label OutputDescriptionLabel;
    }
}

