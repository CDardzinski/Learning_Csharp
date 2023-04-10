using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sentense;

        private void maleButton_Click(object sender, EventArgs e)
        {
            sentense += "małe";
            AnswerLabel.Text = sentense;
        }

        private void rowerButton_Click(object sender, EventArgs e)
        {
            sentense += "rower";
            AnswerLabel.Text = sentense;
        }

        private void toButton2_Click(object sender, EventArgs e)
        {
            sentense += "to";
            AnswerLabel.Text = sentense;
        }

        private void prowadziButton_Click(object sender, EventArgs e)
        {
            sentense += "prowadzi";
            AnswerLabel.Text = sentense;
        }

        private void rozesmianeButton_Click(object sender, EventArgs e)
        {
            sentense += "roześmiane";
            AnswerLabel.Text = sentense;
        }

        private void samochodButton_Click(object sender, EventArgs e)
        {
            sentense += "samochód";
            AnswerLabel.Text = sentense;
        }

        private void ToButton_Click(object sender, EventArgs e)
        {
            sentense += "To";
            AnswerLabel.Text = sentense;
        }

        private void SmiejeSieButton_Click(object sender, EventArgs e)
        {
            sentense += "śmieje się";
            AnswerLabel.Text = sentense;
        }

        private void drobnaButton_Click(object sender, EventArgs e)
        {
            sentense += "drobna";
            AnswerLabel.Text = sentense;
        }

        private void kotButton_Click(object sender, EventArgs e)
        {
            sentense += "kot";
            AnswerLabel.Text = sentense;
        }

        private void taButton2_Click(object sender, EventArgs e)
        {
            sentense += "ta";
            AnswerLabel.Text = sentense;
        }

        private void wykrzyknikButton_Click(object sender, EventArgs e)
        {
            sentense += "!";
            AnswerLabel.Text = sentense;
        }

        private void mowiButton_Click(object sender, EventArgs e)
        {
            sentense += "mówi";
            AnswerLabel.Text = sentense;
        }

        private void ladnaButton_Click(object sender, EventArgs e)
        {
            sentense += "ładna";
            AnswerLabel.Text = sentense;
        }

        private void piesButton_Click(object sender, EventArgs e)
        {
            sentense += "pies";
            AnswerLabel.Text = sentense;
        }

        private void TaButton_Click(object sender, EventArgs e)
        {
            sentense += "Ta";
            AnswerLabel.Text = sentense;
        }

        private void kropkaButton_Click(object sender, EventArgs e)
        {
            sentense += ".";
            AnswerLabel.Text = sentense;
        }

        private void SzukaButton_Click(object sender, EventArgs e)
        {
            sentense += "szuka";
            AnswerLabel.Text = sentense;
        }

        private void DuzyButton_Click(object sender, EventArgs e)
        {
            sentense += "duży";
            AnswerLabel.Text = sentense;
        }

        private void KobietaButton_Click(object sender, EventArgs e)
        {
            sentense += "kobieta";
            AnswerLabel.Text = sentense;
        }

        private void tenButton2_Click(object sender, EventArgs e)
        {
            sentense += "ten";
            AnswerLabel.Text = sentense;
        }

        private void SpacjaButton_Click(object sender, EventArgs e)
        {
            sentense += " ";
            AnswerLabel.Text = sentense;
        }

        private void PatrzyButton_Click(object sender, EventArgs e)
        {
            sentense += "patrzy";
            AnswerLabel.Text = sentense;
        }

        private void EleganckiButton_Click(object sender, EventArgs e)
        {
            sentense += "elegancki";
            AnswerLabel.Text = sentense;
        }

        private void MezczyznaButton_Click(object sender, EventArgs e)
        {
            sentense += "mężczyzna";
            AnswerLabel.Text = sentense;
        }

        private void TenButton_Click(object sender, EventArgs e)
        {
            sentense += "Ten";
            AnswerLabel.Text = sentense;
        }

        private void biegaButton_Click(object sender, EventArgs e)
        {
            sentense += "biega";
            AnswerLabel.Text = sentense;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            sentense = "";
            AnswerLabel.Text = "";
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
