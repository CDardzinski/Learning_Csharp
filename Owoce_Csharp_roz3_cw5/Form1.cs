using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw5
{
    public partial class Form1 : Form
    {
        double GetTemp, SetTemp;

        public Form1()
        {
            InitializeComponent();
        }

        private void ConvertToCelsiusButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetTemp = double.Parse(TempEntredTextBox.Text);

                SetTemp =   (GetTemp - 32.0) / (9.0 / 5.0);

                ConvertTempTextBox.Text = SetTemp.ToString();

                TempValLabel.Text = "st. C";
                TempValBeforLabel.Text = "st. F";
            }
            catch
            {
                MessageBox.Show("Błędne dane wejściowe!");
            }
        }

        private void ConvertToFahrenheitButton_Click(object sender, EventArgs e)
        {
            try 
            {        
                GetTemp = double.Parse(TempEntredTextBox.Text);

                SetTemp = ((9.0 / 5.0) * GetTemp) + 32;

                ConvertTempTextBox.Text = SetTemp.ToString();

                TempValLabel.Text = "st. F";
                TempValBeforLabel.Text = "st. C";
            }
            catch
            {
                MessageBox.Show("Błędne dane wejściowe!");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
