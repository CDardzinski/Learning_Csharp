using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw2
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
                double Tax, Tip, Sum, temp;

                temp = double.Parse(MealPriceTextBox.Text);

                Tip = 0.15 * temp;
                Tax = 0.07 * temp;
                Sum = temp + Tip + Tax;

                TipsTextBox.Text = Tip.ToString("c");
                TaxTextBox.Text = Tax.ToString("c");
                SumTextBox.Text = Sum.ToString("c");
            }
            catch (Exception dupa)
            {
                MessageBox.Show(dupa.Message);
                //MessageBox.Show("Nieprawidlowe dane wejsciowe");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
