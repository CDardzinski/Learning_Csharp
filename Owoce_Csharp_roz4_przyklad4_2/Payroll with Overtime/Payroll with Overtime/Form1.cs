using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Stałe nazwane. 
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;
                
                // Zmienne lokalne. 
                decimal hoursWorked;   // Liczba przepracowanych godzin. 
                decimal hourlyPayRate; // Stawka godzinowa. 
                decimal basePay;       // Wynagrodzenie podstawowe.
                decimal overtimeHours; // Przepracowane nadgodziny.
                decimal overtimePay;   // Wynagrodzenie za nadgodziny. 
                decimal grossPay;      // Wynagrodzenie całkowite. 
                
                // Pobranie liczby przepracowanych godzin i stawki godzinowej. 
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                
                // Obliczenie wynagrodzenia.
                if (hoursWorked > BASE_HOURS)
                {
                    // Obliczenie wynagrodzenia podstawowego (bez nadgodzin).
                    basePay = hourlyPayRate * BASE_HOURS;
                    
                    // Obliczenie liczby przepracowanych nadgodzin. 
                    overtimeHours = hoursWorked - BASE_HOURS;
                    
                    // Obliczenie wynagrodzenia za nadgodziny. 
                    overtimePay = overtimeHours * hourlyPayRate *
                         OT_MULTIPLIER;
                    
                    // Obliczenie wynagrodzenia całkowitego. 
                    grossPay = basePay + overtimePay;
                }
                else 
                {
                    // Obliczenie wynagrodzenia całkowitego. 
                    grossPay = hoursWorked * hourlyPayRate;
                }
                
                // Wyświetlenie obliczonego wynagrodzenia całkowitego. 
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch (Exception ex)
            {
                // Wyświetlenie komunikatu błędu. 
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Usunięcie zawartości kontrolek TextBoxes i grossPayLabel. 
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";
            
            // Aktywowanie kontrolki hoursWorkedTextBox. 
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Zamknięcie formularza. 
            this.Close();
        }
    }
}
