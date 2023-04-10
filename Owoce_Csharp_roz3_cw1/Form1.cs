using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw1
{
    public partial class Form1 : Form
    {
        string FirstName, SecondName, Title, Surname;
        string output;

        public Form1()
        {
            InitializeComponent();
        }

        private void GetDataFromLabel()
        {
            FirstName = FirstNameTextBox.Text;
            SecondName = SecondNameTextBox.Text;
            Title = TitleTextBox.Text;
            Surname = SurnameTextBox.Text;
        }

        private void ShowOutputData()
        {
            OutputLabel.Text = output;
        }

        private void TitFirSecSurButton_Click(object sender, EventArgs e)
        {
            GetDataFromLabel();
            output = Title + " " + FirstName + " " + SecondName + " " + Surname;
            ShowOutputData();
        }
        
        private void FirSecSurButton_Click(object sender, EventArgs e)
        {
            GetDataFromLabel();
            output = FirstName + " " + SecondName + " " + Surname;
            ShowOutputData();
        }
        
        private void FirSurButton_Click(object sender, EventArgs e)
        {
            GetDataFromLabel();
            output = FirstName + " " + Surname;
            ShowOutputData();
        }
        
        private void SurColonFirSecColonTitButton_Click(object sender, EventArgs e)
        {
            GetDataFromLabel();
            output = Surname + ", " + FirstName + " " + SecondName + ", " + Title;
            ShowOutputData();
        }
        
        private void SurColonFirSecBbutton_Click(object sender, EventArgs e)
        {
            GetDataFromLabel();
            output = Surname + ", " + FirstName + " " + SecondName;
            ShowOutputData();
        }
        private void SurColonFirButton_Click(object sender, EventArgs e)
        {
            GetDataFromLabel();
            output = Surname + ", " + FirstName;
            ShowOutputData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
