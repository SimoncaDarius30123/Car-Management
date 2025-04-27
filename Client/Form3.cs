using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Form3 : Form
    {
        Car carToUpdate;
        public Form3(Car car)
        {
            InitializeComponent();
            carToUpdate = car;
        }

        private void updateCarButton_Click(object sender, EventArgs e)
        {
            var service = new ServiceReference1.CarWebServiceSoapClient();
            //-----------------------------------------------------------------------------//

            String model = modelTextBox.Text;
            String brand = brandTextBox.Text;
            String year = yearTextBox.Text;
            String mileage = mileageTextBox.Text;
            String price = priceTextBox.Text;
            String poza = null;
            if(imagePathTextBox.Text.Length != 0)
            {
                poza = imagePathTextBox.Text;
            }

            service.UpdateCar(carToUpdate, model, brand, year, mileage, price,poza);

            MessageBox.Show("Succes!");
            this.Close();
        }
    }
}
