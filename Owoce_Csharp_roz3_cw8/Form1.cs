using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double MinPropertyVal;

            try
            {
                MinPropertyVal = double.Parse(PropertyValueTextBox.Text);

                MinPropertyVal *= 0.8;

                MinInsuranePropertyValueTextBox.Text = MinPropertyVal.ToString();
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
