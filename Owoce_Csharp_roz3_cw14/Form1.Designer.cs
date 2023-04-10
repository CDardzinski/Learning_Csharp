namespace Owoce_Csharp_roz3_cw14
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
            this.TicketSaleGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ZoneALabel = new System.Windows.Forms.Label();
            this.ZoneBLabel = new System.Windows.Forms.Label();
            this.ZoneCLabel = new System.Windows.Forms.Label();
            this.ZoneATextBox = new System.Windows.Forms.TextBox();
            this.ZoneBTextBox = new System.Windows.Forms.TextBox();
            this.ZoneCTextBox = new System.Windows.Forms.TextBox();
            this.TicketValueGroupBox = new System.Windows.Forms.GroupBox();
            this.CostZonaCTextBox = new System.Windows.Forms.TextBox();
            this.CostZonaBTextBox = new System.Windows.Forms.TextBox();
            this.CostZonaATextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SumOfSaleTextBox = new System.Windows.Forms.TextBox();
            this.SumLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TicketSaleGroupBox.SuspendLayout();
            this.TicketValueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketSaleGroupBox
            // 
            this.TicketSaleGroupBox.Controls.Add(this.ZoneCTextBox);
            this.TicketSaleGroupBox.Controls.Add(this.ZoneBTextBox);
            this.TicketSaleGroupBox.Controls.Add(this.ZoneATextBox);
            this.TicketSaleGroupBox.Controls.Add(this.ZoneCLabel);
            this.TicketSaleGroupBox.Controls.Add(this.ZoneBLabel);
            this.TicketSaleGroupBox.Controls.Add(this.ZoneALabel);
            this.TicketSaleGroupBox.Controls.Add(this.label1);
            this.TicketSaleGroupBox.Location = new System.Drawing.Point(36, 37);
            this.TicketSaleGroupBox.Name = "TicketSaleGroupBox";
            this.TicketSaleGroupBox.Size = new System.Drawing.Size(275, 269);
            this.TicketSaleGroupBox.TabIndex = 0;
            this.TicketSaleGroupBox.TabStop = false;
            this.TicketSaleGroupBox.Text = "Sprzedaż biletów";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj liczbę sprzedanych biletów w poszczególnych strefach.";
            // 
            // ZoneALabel
            // 
            this.ZoneALabel.AutoSize = true;
            this.ZoneALabel.Location = new System.Drawing.Point(32, 107);
            this.ZoneALabel.Name = "ZoneALabel";
            this.ZoneALabel.Size = new System.Drawing.Size(45, 13);
            this.ZoneALabel.TabIndex = 1;
            this.ZoneALabel.Text = "Strefa A";
            // 
            // ZoneBLabel
            // 
            this.ZoneBLabel.AutoSize = true;
            this.ZoneBLabel.Location = new System.Drawing.Point(32, 150);
            this.ZoneBLabel.Name = "ZoneBLabel";
            this.ZoneBLabel.Size = new System.Drawing.Size(45, 13);
            this.ZoneBLabel.TabIndex = 2;
            this.ZoneBLabel.Text = "Strefa B";
            // 
            // ZoneCLabel
            // 
            this.ZoneCLabel.AutoSize = true;
            this.ZoneCLabel.Location = new System.Drawing.Point(32, 200);
            this.ZoneCLabel.Name = "ZoneCLabel";
            this.ZoneCLabel.Size = new System.Drawing.Size(45, 13);
            this.ZoneCLabel.TabIndex = 3;
            this.ZoneCLabel.Text = "Strefa C";
            // 
            // ZoneATextBox
            // 
            this.ZoneATextBox.Location = new System.Drawing.Point(128, 104);
            this.ZoneATextBox.Name = "ZoneATextBox";
            this.ZoneATextBox.Size = new System.Drawing.Size(100, 20);
            this.ZoneATextBox.TabIndex = 4;
            // 
            // ZoneBTextBox
            // 
            this.ZoneBTextBox.Location = new System.Drawing.Point(128, 147);
            this.ZoneBTextBox.Name = "ZoneBTextBox";
            this.ZoneBTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZoneBTextBox.TabIndex = 5;
            // 
            // ZoneCTextBox
            // 
            this.ZoneCTextBox.Location = new System.Drawing.Point(128, 197);
            this.ZoneCTextBox.Name = "ZoneCTextBox";
            this.ZoneCTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZoneCTextBox.TabIndex = 6;
            // 
            // TicketValueGroupBox
            // 
            this.TicketValueGroupBox.Controls.Add(this.SumLabel);
            this.TicketValueGroupBox.Controls.Add(this.SumOfSaleTextBox);
            this.TicketValueGroupBox.Controls.Add(this.CostZonaCTextBox);
            this.TicketValueGroupBox.Controls.Add(this.CostZonaBTextBox);
            this.TicketValueGroupBox.Controls.Add(this.CostZonaATextBox);
            this.TicketValueGroupBox.Controls.Add(this.label2);
            this.TicketValueGroupBox.Controls.Add(this.label3);
            this.TicketValueGroupBox.Controls.Add(this.label4);
            this.TicketValueGroupBox.Location = new System.Drawing.Point(414, 37);
            this.TicketValueGroupBox.Name = "TicketValueGroupBox";
            this.TicketValueGroupBox.Size = new System.Drawing.Size(275, 269);
            this.TicketValueGroupBox.TabIndex = 7;
            this.TicketValueGroupBox.TabStop = false;
            this.TicketValueGroupBox.Text = "Wpływy ze sprzedaży";
            // 
            // CostZonaCTextBox
            // 
            this.CostZonaCTextBox.Location = new System.Drawing.Point(128, 197);
            this.CostZonaCTextBox.Name = "CostZonaCTextBox";
            this.CostZonaCTextBox.ReadOnly = true;
            this.CostZonaCTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostZonaCTextBox.TabIndex = 6;
            // 
            // CostZonaBTextBox
            // 
            this.CostZonaBTextBox.Location = new System.Drawing.Point(128, 147);
            this.CostZonaBTextBox.Name = "CostZonaBTextBox";
            this.CostZonaBTextBox.ReadOnly = true;
            this.CostZonaBTextBox.Size = new System.Drawing.Size(100, 20);
            this.CostZonaBTextBox.TabIndex = 5;
            // 
            // CostZonaATextBox
            // 
            this.CostZonaATextBox.Location = new System.Drawing.Point(128, 104);
            this.CostZonaATextBox.Name = "CostZonaATextBox";
            this.CostZonaATextBox.ReadOnly = true;
            this.CostZonaATextBox.Size = new System.Drawing.Size(100, 20);
            this.CostZonaATextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Strefa C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Strefa B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Strefa A";
            // 
            // SumOfSaleTextBox
            // 
            this.SumOfSaleTextBox.Location = new System.Drawing.Point(128, 234);
            this.SumOfSaleTextBox.Name = "SumOfSaleTextBox";
            this.SumOfSaleTextBox.ReadOnly = true;
            this.SumOfSaleTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumOfSaleTextBox.TabIndex = 7;
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Location = new System.Drawing.Point(32, 237);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(40, 13);
            this.SumLabel.TabIndex = 8;
            this.SumLabel.Text = "Razem";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(153, 335);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(111, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Oblicz wpływy";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(307, 335);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(111, 23);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Wyczyść";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(474, 335);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(111, 23);
            this.QuitButton.TabIndex = 10;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 385);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.TicketValueGroupBox);
            this.Controls.Add(this.TicketSaleGroupBox);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 14";
            this.TicketSaleGroupBox.ResumeLayout(false);
            this.TicketSaleGroupBox.PerformLayout();
            this.TicketValueGroupBox.ResumeLayout(false);
            this.TicketValueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TicketSaleGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZoneCTextBox;
        private System.Windows.Forms.TextBox ZoneBTextBox;
        private System.Windows.Forms.TextBox ZoneATextBox;
        private System.Windows.Forms.Label ZoneCLabel;
        private System.Windows.Forms.Label ZoneBLabel;
        private System.Windows.Forms.Label ZoneALabel;
        private System.Windows.Forms.GroupBox TicketValueGroupBox;
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.TextBox SumOfSaleTextBox;
        private System.Windows.Forms.TextBox CostZonaCTextBox;
        private System.Windows.Forms.TextBox CostZonaBTextBox;
        private System.Windows.Forms.TextBox CostZonaATextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button QuitButton;
    }
}

