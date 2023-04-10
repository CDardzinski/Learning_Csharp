using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculeButton_Click(object sender, EventArgs e)
        {
            const int SinglePart = 10;
            const int SinglePartCalory = 300;
            double EntredQuantity, CaloryEaten;
            double OneCookieCalory = (double)SinglePartCalory / (double)(40 / SinglePart);

            try
            {
                EntredQuantity = double.Parse(HowManyEatenTextBox.Text);
                CaloryEaten = EntredQuantity * OneCookieCalory;

                CaloryEatenTextBox.Text = CaloryEaten.ToString();
            }
            catch 
            {
                MessageBox.Show("Błędne dane wejściowe");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
