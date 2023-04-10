using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculeButton_Click(object sender, EventArgs e)
        {
            try
            {
                double CarSpeedEntred, CalculeDistance;

                CarSpeedEntred = double.Parse(CarSpeedTextBox.Text);

                CalculeDistance = CarSpeedEntred * 5.0;
                FiveHoursTextBox.Text = CalculeDistance.ToString();

                CalculeDistance = CarSpeedEntred * 8.0;
                EightHoursTextBox.Text = CalculeDistance.ToString();

                CalculeDistance = CarSpeedEntred * 12.0;
                TwelveHoursTextBox.Text = CalculeDistance.ToString();
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
