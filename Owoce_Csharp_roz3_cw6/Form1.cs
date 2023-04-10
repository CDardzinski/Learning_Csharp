using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculeBmiButton_Click(object sender, EventArgs e)
        {
            double BMI, weight, height;

            try
            {
                weight = double.Parse(WeightTextBox.Text);
                height = double.Parse(HeightTextBox.Text);

                BMI = weight / (height * height);

                BmiTextBox.Text = BMI.ToString();
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
