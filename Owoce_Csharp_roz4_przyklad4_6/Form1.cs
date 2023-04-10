using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Owoce_Csharp_roz4_przyklad4_6
{
    public partial class TimeZone : Form
    {
        public TimeZone()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string city; //Ta zmienna przechowuje nazwę mista

            if(CityListBox.SelectedIndex != -1)
            {
                city = CityListBox.SelectedItem.ToString(); //Pobranie zaznaczone elementu na liście

                //Ustalenie i wyświetlenie strefy czasowej
                switch(city)
                {
                    case "Honolulu":
                        TimeZoneLabel.Text = "hawajsko-aleucka";
                        break;
                    case "San Francisco":
                        TimeZoneLabel.Text = "pacyficzna";
                        break;
                    case "Denver":
                        TimeZoneLabel.Text = "górska";
                        break;
                    case "Minneapolis":
                        TimeZoneLabel.Text = "centralna";
                        break;
                    case "Nowy Jork":
                        TimeZoneLabel.Text = "wschodnia";
                        break;
                }
            }
            else 
            {
                //żadne miasto nie zostało wybrane
                MessageBox.Show("Wybierz miasto.");
            }
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
