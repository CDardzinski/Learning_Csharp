using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_cw11
{
    public partial class Form1 : Form
    {
        double MontlyCost = 0.0, AllCost = 0.0;
        public Form1()
        {
            InitializeComponent();
        }
        private void MontlySumButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MontlyCost > 0.0) MontlyCost = 0.0;

                MontlyCost += double.Parse(LoanInstallmentTextBox.Text);
                MontlyCost += double.Parse(InsurancePremimTextBox.Text);
                MontlyCost += double.Parse(FuleTextBox.Text);
                MontlyCost += double.Parse(OilTextBox.Text);
                MontlyCost += double.Parse(TyresTextBox.Text);
                MontlyCost += double.Parse(ServiceTextBox.Text);

                MontlySumTextBox.Text = MontlyCost.ToString();
            }
            catch
            {
                MontlyCost = 0.0;
                MessageBox.Show("Błędne dane wejściowe!");
            }
        }

        private void AllCostButton_Click(object sender, EventArgs e)
        {
            if(MontlyCost > 0.0)
            {
                AllCost += MontlyCost;
                MontlyCost = 0.0;
            }

            AllCostTextBox.Text = AllCost.ToString();

        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
