using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Owoce_Csharp_roz3_przyklad_StringVariableDemo
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowNameButton_Click(object sender, EventArgs e)
        {
            string fullName;

            //konkatencja dwóch pół textBox
            fullName = FirstNameTextBox.Text + " " + LastNameTextBox.Text;

            FullNameTextBox.Text = fullName;
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
