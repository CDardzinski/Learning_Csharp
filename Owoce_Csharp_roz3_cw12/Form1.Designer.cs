namespace Owoce_Csharp_roz3_cw12
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SpaceTextBox = new System.Windows.Forms.TextBox();
            this.PaintCostTextBox = new System.Windows.Forms.TextBox();
            this.SpaceLabel = new System.Windows.Forms.Label();
            this.PaintCostLabel = new System.Windows.Forms.Label();
            this.CalculeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SumPaintTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PaintTimeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SumPaintCostTextBox = new System.Windows.Forms.TextBox();
            this.WorkLabel = new System.Windows.Forms.Label();
            this.SumWorkCostTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SumOfAllTextBox = new System.Windows.Forms.TextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CalculeButton);
            this.groupBox1.Controls.Add(this.PaintCostLabel);
            this.groupBox1.Controls.Add(this.SpaceLabel);
            this.groupBox1.Controls.Add(this.PaintCostTextBox);
            this.groupBox1.Controls.Add(this.SpaceTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Podstawowe parametry";
            // 
            // SpaceTextBox
            // 
            this.SpaceTextBox.Location = new System.Drawing.Point(162, 28);
            this.SpaceTextBox.Name = "SpaceTextBox";
            this.SpaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.SpaceTextBox.TabIndex = 0;
            // 
            // PaintCostTextBox
            // 
            this.PaintCostTextBox.Location = new System.Drawing.Point(162, 76);
            this.PaintCostTextBox.Name = "PaintCostTextBox";
            this.PaintCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.PaintCostTextBox.TabIndex = 1;
            // 
            // SpaceLabel
            // 
            this.SpaceLabel.AutoSize = true;
            this.SpaceLabel.Location = new System.Drawing.Point(6, 31);
            this.SpaceLabel.Name = "SpaceLabel";
            this.SpaceLabel.Size = new System.Drawing.Size(150, 13);
            this.SpaceLabel.TabIndex = 2;
            this.SpaceLabel.Text = "Powierzchnia do pomalowania";
            // 
            // PaintCostLabel
            // 
            this.PaintCostLabel.AutoSize = true;
            this.PaintCostLabel.Location = new System.Drawing.Point(86, 79);
            this.PaintCostLabel.Name = "PaintCostLabel";
            this.PaintCostLabel.Size = new System.Drawing.Size(70, 13);
            this.PaintCostLabel.TabIndex = 3;
            this.PaintCostLabel.Text = "Koszt 4l farby";
            // 
            // CalculeButton
            // 
            this.CalculeButton.Location = new System.Drawing.Point(102, 115);
            this.CalculeButton.Name = "CalculeButton";
            this.CalculeButton.Size = new System.Drawing.Size(75, 23);
            this.CalculeButton.TabIndex = 4;
            this.CalculeButton.Text = "Przelicz";
            this.CalculeButton.UseVisualStyleBackColor = true;
            this.CalculeButton.Click += new System.EventHandler(this.CalculeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "m^2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.SumOfAllTextBox);
            this.groupBox2.Controls.Add(this.WorkLabel);
            this.groupBox2.Controls.Add(this.SumWorkCostTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.SumPaintCostTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PaintTimeTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SumPaintTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 170);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wynik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ilośc farby (litry)";
            // 
            // SumPaintTextBox
            // 
            this.SumPaintTextBox.Location = new System.Drawing.Point(162, 19);
            this.SumPaintTextBox.Name = "SumPaintTextBox";
            this.SumPaintTextBox.ReadOnly = true;
            this.SumPaintTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumPaintTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czas malowania (godziny)";
            // 
            // PaintTimeTextBox
            // 
            this.PaintTimeTextBox.Location = new System.Drawing.Point(162, 45);
            this.PaintTimeTextBox.Name = "PaintTimeTextBox";
            this.PaintTimeTextBox.ReadOnly = true;
            this.PaintTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PaintTimeTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Koszt farby";
            // 
            // SumPaintCostTextBox
            // 
            this.SumPaintCostTextBox.Location = new System.Drawing.Point(162, 71);
            this.SumPaintCostTextBox.Name = "SumPaintCostTextBox";
            this.SumPaintCostTextBox.ReadOnly = true;
            this.SumPaintCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumPaintCostTextBox.TabIndex = 7;
            // 
            // WorkLabel
            // 
            this.WorkLabel.AutoSize = true;
            this.WorkLabel.Location = new System.Drawing.Point(94, 100);
            this.WorkLabel.Name = "WorkLabel";
            this.WorkLabel.Size = new System.Drawing.Size(62, 13);
            this.WorkLabel.TabIndex = 10;
            this.WorkLabel.Text = "Koszt pracy";
            // 
            // SumWorkCostTextBox
            // 
            this.SumWorkCostTextBox.Location = new System.Drawing.Point(162, 97);
            this.SumWorkCostTextBox.Name = "SumWorkCostTextBox";
            this.SumWorkCostTextBox.ReadOnly = true;
            this.SumWorkCostTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumWorkCostTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Koszt całkowity";
            // 
            // SumOfAllTextBox
            // 
            this.SumOfAllTextBox.Location = new System.Drawing.Point(162, 133);
            this.SumOfAllTextBox.Name = "SumOfAllTextBox";
            this.SumOfAllTextBox.ReadOnly = true;
            this.SumOfAllTextBox.Size = new System.Drawing.Size(100, 20);
            this.SumOfAllTextBox.TabIndex = 11;
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(114, 369);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 7;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 415);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CalculeButton;
        private System.Windows.Forms.Label PaintCostLabel;
        private System.Windows.Forms.Label SpaceLabel;
        private System.Windows.Forms.TextBox PaintCostTextBox;
        private System.Windows.Forms.TextBox SpaceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SumOfAllTextBox;
        private System.Windows.Forms.Label WorkLabel;
        private System.Windows.Forms.TextBox SumWorkCostTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SumPaintCostTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PaintTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SumPaintTextBox;
        private System.Windows.Forms.Button QuitButton;
    }
}

