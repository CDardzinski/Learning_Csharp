using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      

        private void CalculeButton_Click(object sender, EventArgs e)
        {
            double EntredValue, TaxFromProperty;

            try
            {
                EntredValue = double.Parse(PropertyValueTextBox.Text);

                TaxFromProperty = (EntredValue / 100.0) * 0.64;

                TaxTextBox.Text = TaxFromProperty.ToString("c");

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
