using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz3_przyklad3_2
{
    public partial class FuelEconomyPanel : Form
    {
        public FuelEconomyPanel()
        {
            InitializeComponent();
        }

        private void CalculateMPGbutton_Click(object sender, EventArgs e)
        {
            /*
            //Wersja pierwsza zgodna z przykładem 3.2  
             
            double miles, gallons, mpg;

            miles = double.Parse(MilesTextBox.Text);

            gallons = double.Parse(GallonsTextBox.Text);

            mpg = miles / gallons;

            MPGTextBox.Text = mpg.ToString();
            */

            /*
            //Wersja poprawiona z dodaną procedurą obsługi wyjątku try - catch

            try
            {
                double miles, gallons, mpg;

                miles = double.Parse(MilesTextBox.Text);

                gallons = double.Parse(GallonsTextBox.Text);

                mpg = miles / gallons;

                MPGTextBox.Text = mpg.ToString();
            }
            catch
            {
                MessageBox.Show("Podano nieprawidłowe dane.");
            }
            */


            //Wersja z koejną możliwością użycia procedury obsługi wyjątku try - catch

            try
            {
                double miles, gallons, mpg;

                miles = double.Parse(MilesTextBox.Text);

                gallons = double.Parse(GallonsTextBox.Text);

                mpg = miles / gallons;

                MPGTextBox.Text = mpg.ToString();
            } 
            catch (Exception jakasNazwa) //Nazwa domyślnie ustawia się na ex, ale może być dowolna
            {
                MessageBox.Show(jakasNazwa.Message);//domyślny komunikat błędu
                //MessageBox.Show("Podano nieprawidłowe dane.");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
