namespace Owoce_Csharp_roz3_cw1
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
            this.PersonalDataGrupeBox = new System.Windows.Forms.GroupBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.SecondNameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.QuitButton = new System.Windows.Forms.Button();
            this.ShowDataGroupBox = new System.Windows.Forms.GroupBox();
            this.TitFirSecSurButton = new System.Windows.Forms.Button();
            this.FirSecSurButton = new System.Windows.Forms.Button();
            this.FirSurButton = new System.Windows.Forms.Button();
            this.SurColonFirSecColonTitButton = new System.Windows.Forms.Button();
            this.SurColonFirSecBbutton = new System.Windows.Forms.Button();
            this.SurColonFirButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.PersonalDataGrupeBox.SuspendLayout();
            this.ShowDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PersonalDataGrupeBox
            // 
            this.PersonalDataGrupeBox.Controls.Add(this.TitleLabel);
            this.PersonalDataGrupeBox.Controls.Add(this.SurnameLabel);
            this.PersonalDataGrupeBox.Controls.Add(this.SecondNameLabel);
            this.PersonalDataGrupeBox.Controls.Add(this.FirstNameLabel);
            this.PersonalDataGrupeBox.Controls.Add(this.TitleTextBox);
            this.PersonalDataGrupeBox.Controls.Add(this.SurnameTextBox);
            this.PersonalDataGrupeBox.Controls.Add(this.SecondNameTextBox);
            this.PersonalDataGrupeBox.Controls.Add(this.FirstNameTextBox);
            this.PersonalDataGrupeBox.Location = new System.Drawing.Point(27, 28);
            this.PersonalDataGrupeBox.Name = "PersonalDataGrupeBox";
            this.PersonalDataGrupeBox.Size = new System.Drawing.Size(271, 221);
            this.PersonalDataGrupeBox.TabIndex = 0;
            this.PersonalDataGrupeBox.TabStop = false;
            this.PersonalDataGrupeBox.Text = "Dane Personalne";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(134, 34);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.Location = new System.Drawing.Point(134, 76);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SecondNameTextBox.TabIndex = 1;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(134, 119);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(134, 162);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(33, 37);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(26, 13);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "Imie";
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(33, 79);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(60, 13);
            this.SecondNameLabel.TabIndex = 5;
            this.SecondNameLabel.Text = "Drugie Imie";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(33, 126);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(53, 13);
            this.SurnameLabel.TabIndex = 6;
            this.SurnameLabel.Text = "Nazwisko";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(33, 165);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(32, 13);
            this.TitleLabel.TabIndex = 7;
            this.TitleLabel.Text = "Tytuł";
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(508, 388);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 1;
            this.QuitButton.Text = "Zakończ";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // ShowDataGroupBox
            // 
            this.ShowDataGroupBox.Controls.Add(this.SurColonFirButton);
            this.ShowDataGroupBox.Controls.Add(this.SurColonFirSecBbutton);
            this.ShowDataGroupBox.Controls.Add(this.SurColonFirSecColonTitButton);
            this.ShowDataGroupBox.Controls.Add(this.FirSurButton);
            this.ShowDataGroupBox.Controls.Add(this.FirSecSurButton);
            this.ShowDataGroupBox.Controls.Add(this.TitFirSecSurButton);
            this.ShowDataGroupBox.Location = new System.Drawing.Point(337, 28);
            this.ShowDataGroupBox.Name = "ShowDataGroupBox";
            this.ShowDataGroupBox.Size = new System.Drawing.Size(246, 281);
            this.ShowDataGroupBox.TabIndex = 3;
            this.ShowDataGroupBox.TabStop = false;
            this.ShowDataGroupBox.Text = "Prezentacja danych";
            // 
            // TitFirSecSurButton
            // 
            this.TitFirSecSurButton.Location = new System.Drawing.Point(22, 34);
            this.TitFirSecSurButton.Name = "TitFirSecSurButton";
            this.TitFirSecSurButton.Size = new System.Drawing.Size(202, 23);
            this.TitFirSecSurButton.TabIndex = 0;
            this.TitFirSecSurButton.Text = "Tytuł Imie Drugie Imie Nazwisko";
            this.TitFirSecSurButton.UseVisualStyleBackColor = true;
            this.TitFirSecSurButton.Click += new System.EventHandler(this.TitFirSecSurButton_Click);
            // 
            // FirSecSurButton
            // 
            this.FirSecSurButton.Location = new System.Drawing.Point(22, 76);
            this.FirSecSurButton.Name = "FirSecSurButton";
            this.FirSecSurButton.Size = new System.Drawing.Size(202, 23);
            this.FirSecSurButton.TabIndex = 1;
            this.FirSecSurButton.Text = "Imie Drugie Imie Nazwisko";
            this.FirSecSurButton.UseVisualStyleBackColor = true;
            this.FirSecSurButton.Click += new System.EventHandler(this.FirSecSurButton_Click);
            // 
            // FirSurButton
            // 
            this.FirSurButton.Location = new System.Drawing.Point(22, 119);
            this.FirSurButton.Name = "FirSurButton";
            this.FirSurButton.Size = new System.Drawing.Size(202, 23);
            this.FirSurButton.TabIndex = 2;
            this.FirSurButton.Text = "Imie Nazwisko";
            this.FirSurButton.UseVisualStyleBackColor = true;
            this.FirSurButton.Click += new System.EventHandler(this.FirSurButton_Click);
            // 
            // SurColonFirSecColonTitButton
            // 
            this.SurColonFirSecColonTitButton.Location = new System.Drawing.Point(22, 162);
            this.SurColonFirSecColonTitButton.Name = "SurColonFirSecColonTitButton";
            this.SurColonFirSecColonTitButton.Size = new System.Drawing.Size(202, 23);
            this.SurColonFirSecColonTitButton.TabIndex = 3;
            this.SurColonFirSecColonTitButton.Text = "Nazwisko, Imie Drugie Imie, Tytuł";
            this.SurColonFirSecColonTitButton.UseVisualStyleBackColor = true;
            this.SurColonFirSecColonTitButton.Click += new System.EventHandler(this.SurColonFirSecColonTitButton_Click);
            // 
            // SurColonFirSecBbutton
            // 
            this.SurColonFirSecBbutton.Location = new System.Drawing.Point(22, 209);
            this.SurColonFirSecBbutton.Name = "SurColonFirSecBbutton";
            this.SurColonFirSecBbutton.Size = new System.Drawing.Size(202, 23);
            this.SurColonFirSecBbutton.TabIndex = 4;
            this.SurColonFirSecBbutton.Text = "Nazwisko, Imie Drugie Imie";
            this.SurColonFirSecBbutton.UseVisualStyleBackColor = true;
            this.SurColonFirSecBbutton.Click += new System.EventHandler(this.SurColonFirSecBbutton_Click);
            // 
            // SurColonFirButton
            // 
            this.SurColonFirButton.Location = new System.Drawing.Point(22, 252);
            this.SurColonFirButton.Name = "SurColonFirButton";
            this.SurColonFirButton.Size = new System.Drawing.Size(202, 23);
            this.SurColonFirButton.TabIndex = 5;
            this.SurColonFirButton.Text = "Nazwisko, Imie";
            this.SurColonFirButton.UseVisualStyleBackColor = true;
            this.SurColonFirButton.Click += new System.EventHandler(this.SurColonFirButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OutputLabel.Location = new System.Drawing.Point(77, 330);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(450, 25);
            this.OutputLabel.TabIndex = 4;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 437);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.ShowDataGroupBox);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.PersonalDataGrupeBox);
            this.Name = "Form1";
            this.Text = "Ćwiczenie 3.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PersonalDataGrupeBox.ResumeLayout(false);
            this.PersonalDataGrupeBox.PerformLayout();
            this.ShowDataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PersonalDataGrupeBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox SecondNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.GroupBox ShowDataGroupBox;
        private System.Windows.Forms.Button SurColonFirButton;
        private System.Windows.Forms.Button SurColonFirSecBbutton;
        private System.Windows.Forms.Button SurColonFirSecColonTitButton;
        private System.Windows.Forms.Button FirSurButton;
        private System.Windows.Forms.Button FirSecSurButton;
        private System.Windows.Forms.Button TitFirSecSurButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

