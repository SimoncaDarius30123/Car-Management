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

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListBox();
        }

        private void InitializeListBox()
        {
            var service = new ServiceReference1.CarWebServiceSoapClient();
            var cars = service.GetAllCars();
            
            foreach ( var car in cars )
            {
                listBox1.Items.Add(car.Model + " " + car.Marca + " " + car.AnFabricatie);
            }
            

            listBox1.SelectedIndex = 0;  
        }

        private void deleteCarButton_Click(object sender, EventArgs e)
        {
            var service = new ServiceReference1.CarWebServiceSoapClient();
            var cars = service.GetAllCars();
            Car carToUpdate = null;

            String[] listElement = listBox1.SelectedItem.ToString().Split(' ');
            foreach (var car in cars)
            {
                if (car.Model.Equals(listElement[0]) && car.Marca.Equals(listElement[1]) && car.AnFabricatie.ToString().Equals(listElement[2]))
                {
                    carToUpdate = car;
                }
            }

            service.DeleteCar(carToUpdate);

            listBox1.Items.Clear();
            InitializeListBox();
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            var service = new ServiceReference1.CarWebServiceSoapClient();
            var cars = service.GetAllCars();

            String[] listElement = listBox1.SelectedItem.ToString().Split(' ');
            foreach(var car in cars)
            {
                if (car.Model.Equals(listElement[0]) && car.Marca.Equals(listElement[1]) && car.AnFabricatie.ToString().Equals(listElement[2]))
                {
                    idTextBox.Text = car.Id.ToString();
                    marcaTextBox.Text = car.Marca.ToString();
                    modelTextBox.Text = car.Model.ToString();
                    anDeFabricatieTextBox.Text = car.AnFabricatie.ToString();
                    kilometrajTextBox.Text = car.Kilometraj.ToString();
                    pretTextBox.Text = car.Pret.ToString() + " €";
                    pictureBox1.Load(car.Poza);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        private void newCarButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            InitializeListBox();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var service = new ServiceReference1.CarWebServiceSoapClient();
            var cars = service.GetAllCars();
            Car carToUpdate = null;

            String[] listElement = listBox1.SelectedItem.ToString().Split(' ');
            foreach (var car in cars)
            {
                if (car.Model.Equals(listElement[0]) && car.Marca.Equals(listElement[1]) && car.AnFabricatie.ToString().Equals(listElement[2]))
                {
                    carToUpdate = car;
                }
            }
            listBox1.Items.Clear();
            Form3 form3 = new Form3(carToUpdate);
            form3.ShowDialog();
            InitializeListBox();
        }
    }
}
