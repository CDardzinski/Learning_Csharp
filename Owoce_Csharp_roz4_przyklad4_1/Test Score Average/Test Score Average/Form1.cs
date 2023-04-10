using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
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
                const double HIGH_SCORE = 95.0;      // Wartość doskonałej średniej.
                double test1, test2, test3, average; // Zmienne

                // Pobranie wyników z trzech sprawdzianów. 
                test1 = double.Parse(test1TextBox.Text);
                test2 = double.Parse(test2TextBox.Text);
                test3 = double.Parse(test3TextBox.Text);

                // Obliczenie średniej z tych sprawdzianów. 
                average = (test1 + test2 + test3) / 3.0;

                // Wyświetlenie obliczonej średniej zaokrąglonej do dwóch miejsc po przecinku.
                averageLabel.Text = average.ToString("n1");

                // Jeżeli średnia jest większa niż HIGH_SCORE, należy
                // pogratulować użytkownikowi w oknie komunikatu. 
                if (average > HIGH_SCORE)
                {
                    MessageBox.Show("Gratulacje! Doskonały wynik!");
                }
            }
            catch (Exception ex)
            {
                // Wyświetlenie domyślnego komunikatu błędu. 
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Usunięcie zawartości kontrolek TextBoxes i Label. 
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
            
            // Uaktywnienie kontrolki test1TestBox.
            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Zamknięcie formularza. 
            this.Close();
        }
    }
}
