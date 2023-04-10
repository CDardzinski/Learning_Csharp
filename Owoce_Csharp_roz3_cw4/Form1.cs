using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw4
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
                double EntredItemValue, TaxState, TaxShire, SumOfTaxe, SumOfAll;

                EntredItemValue = double.Parse(ItemValueTextBox.Text);

                TaxState = EntredItemValue * 0.04;
                TaxStateTextBox.Text = TaxState.ToString("c");

                TaxShire = EntredItemValue * 0.02;
                ShireTaxTextBox.Text = TaxShire.ToString("c");

                SumOfTaxe = TaxState + TaxShire;
                TaxSumTextBox.Text = SumOfTaxe.ToString("c");

                SumOfAll = EntredItemValue + TaxState + TaxShire;
                SumItemTaxTextBox.Text = SumOfAll.ToString("c");

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
