using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Stałe nazwane. 
                const decimal MINIMUM_SALARY = 40000m;
                const int MINIMUM_YEARS_ON_JOB = 2;
                
                // Zmienne lokalne. 
                decimal salary;
                int yearsOnJob;
                
                // Pobranie wynagrodzenia i liczby lat pracy. 
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOnJob = int.Parse(yearsTextBox.Text);

                // Ustalenie zdolności kredytowej. 
                if (salary >= MINIMUM_SALARY)
                {
                    if (yearsOnJob >= MINIMUM_YEARS_ON_JOB)
                    {
                        // Klient ma zdolność kredytową. 
                        decisionLabel.Text = "Masz zdolność kredytową.";
                    }
                    else
                    {
                        // Klient nie ma zdolności kredytowej. 
                        decisionLabel.Text = "Musisz być zatrudniony " +
                            "przez przynajmniej 2 lata u obecnego pracodawcy.";
                    }
                }
                else
                {
                    // Klient nie ma zdolności kredytowej. 
                    decisionLabel.Text = "Musisz zarabiać przynajmniej " +
                        "40000.00 zł rocznie.";
                }
            }
            catch (Exception ex)
            {
                // Wyświetlenie komunikatu błędu. 
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Usunięcie zawartości kontrolek TextBoxes i decisionLabel. 
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";
            
            // Aktywowanie kontrolki salaryTextBox. 
            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Zamknięcie formularza. 
            this.Close();
        }
    }
}
