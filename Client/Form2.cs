using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form2 : Form
    {

        public class Car
        {
            public int Id { get; set; }
            public string Marca { get; set; }
            public string Model { get; set; }
            public int AnFabricatie { get; set; }
            public int Kilometraj { get; set; }
            public string Poza { get; set; }
            public decimal Pret { get; set; }
        }
        public Form2()
        {
            InitializeComponent();
        }



        private void addCarButton_Click(object sender, EventArgs e)
        {
            var service = new ServiceReference1.CarWebServiceSoapClient();

            String model = modelTextBox.Text;
            String brand = brandTextBox.Text;
            int year = 0; 
            int mileage = 0;
            decimal price = 0;
            if (yearTextBox.Text.Length != 0 && mileageTextBox.Text.Length!=0 && priceTextBox.Text.Length!=0)
            {
                year = Convert.ToInt32(yearTextBox.Text);
                mileage = Convert.ToInt32(mileageTextBox.Text);
                price = Convert.ToDecimal(priceTextBox.Text);
            }
            
            
            String poza = imagePathTextBox.Text;

            if (model != null && brand != null && year > 0 && mileage > 0 && price > 0 && poza != null) { 
                var car = new ServiceReference1.Car
                {
                    Model = model,
                    Marca = brand,
                    AnFabricatie = year,
                    Kilometraj = mileage,
                    Poza = poza,
                    Pret = price
                };
                service.AddCar(car);
                MessageBox.Show("The car has been added succesfully!");
                this.Close();
            }
            
            else
            {
                MessageBox.Show("You need to complete all fields!");
            }
        }
    }
}
