using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Tema2
{
    /// <summary>
    /// Summary description for CarWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CarWebService : System.Web.Services.WebService
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


        [WebMethod]
        public List<Car> GetAllCars()
        {
            List<Car> cars = new List<Car>();
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Facultate An3\II-laborator\Tema2\Tema2\App_Data\CarDatabase.mdf; Integrated Security = True";
            myConnection.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cars", myConnection);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Car car = new Car()
                {
                    Id = (int)reader["Id"],
                    Model = reader["Model"].ToString(),
                    Marca = reader["Marca"].ToString(),
                    AnFabricatie = (int)reader["AnFabricatie"],
                    Kilometraj = (int)reader["Kilometraj"],
                    Pret = (decimal)reader["Pret"],
                    Poza = reader["Poza"].ToString()
                };
                cars.Add(car);
            }
            return cars;
        }

        [WebMethod]
        public void AddCar(Car car)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Facultate An3\II-laborator\Tema2\Tema2\App_Data\CarDatabase.mdf; Integrated Security = True";
            myConnection.Open();

            String model = car.Model;
            String marca = car.Marca;
            int anDeFabricatie = car.AnFabricatie;
            int km = car.Kilometraj;
            decimal pret = car.Pret;
            String poza = car.Poza;

            

               SqlCommand command = new SqlCommand("INSERT INTO Cars (Model, Marca, AnFabricatie, Kilometraj, Poza, Pret) VALUES (@Model, @Marca, @AnFabricatie, @Kilometraj, @Poza, @Pret )", myConnection);
               command.Parameters.Add("@Model", SqlDbType.Text).Value = model;
               command.Parameters.Add("@Marca", SqlDbType.Text).Value = marca;
               command.Parameters.Add("@AnFabricatie", SqlDbType.Int).Value = anDeFabricatie;
               command.Parameters.Add("@Kilometraj", SqlDbType.Int).Value = km;
               command.Parameters.Add("@Pret", SqlDbType.Decimal).Value = pret;
               command.Parameters.Add("@Poza", SqlDbType.Text).Value = poza;
               command.ExecuteNonQuery(); // sa apara in baza de date

              myConnection.Close();
        }

        [WebMethod]
        public void UpdateCar(Car car,String newModel,String newMarca,String newAnDeFabricatie,String newKm,String newPret,String newPoza)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Facultate An3\II-laborator\Tema2\Tema2\App_Data\CarDatabase.mdf; Integrated Security = True";
            myConnection.Open();

            String model = car.Model;
            String marca =car.Marca;
            int anDeFabricatie = car.AnFabricatie;
            int km = car.Kilometraj;
            decimal pret = car.Pret;
            String poza = car.Poza;

            if(newModel.Length!=0)
            {
                model = newModel;
            }
            else
            {
                model = car.Model;
            }
            if(newMarca.Length!=0)
            {
                marca = newMarca;
            }
            else
            {
                marca = car.Marca;
            }
            if(newAnDeFabricatie.Length !=0)
            {
                anDeFabricatie = Convert.ToInt32(newAnDeFabricatie);
            }
            else
            {
                anDeFabricatie = car.AnFabricatie;
            }
            if(newKm.Length !=0)
            {
                km = Convert.ToInt32(newKm);
            }
            else
            {
                km = car.Kilometraj;
            }
            if(newPret.Length!=0)
            {
                pret = Convert.ToDecimal(newPret);
            }
            else
            {
                pret = car.Pret;
            }
            if ( newPoza != null)
            {
                poza = newPoza;
            }
            else
            {
                poza = car.Poza;
            }

            SqlCommand command = new SqlCommand("UPDATE Cars SET  Model = @Model, Marca = @Marca, AnFabricatie = @AnFabricatie, Kilometraj = @Kilometraj, Poza = @Poza, Pret = @Pret    WHERE Id = @Id", myConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = car.Id;
            command.Parameters.Add("@Model", SqlDbType.Text).Value = model;
            command.Parameters.Add("@Marca", SqlDbType.Text).Value = marca;
            command.Parameters.Add("@AnFabricatie", SqlDbType.Int).Value = anDeFabricatie;
            command.Parameters.Add("@Kilometraj", SqlDbType.Int).Value = km;
            command.Parameters.Add("@Pret", SqlDbType.Decimal).Value = pret;
            command.Parameters.Add("@Poza", SqlDbType.Text).Value = poza;
            command.ExecuteNonQuery(); // daca nu apelam nu se face insert in database

            myConnection.Close();
        }

        [WebMethod]
        public void DeleteCar(Car car)
        {
            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Facultate An3\II-laborator\Tema2\Tema2\App_Data\CarDatabase.mdf; Integrated Security = True";
            myConnection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM Cars WHERE Id = @Id", myConnection);
            command.Parameters.Add("@Id", SqlDbType.Int).Value = car.Id;
            command.ExecuteNonQuery(); // daca nu apelam nu se face insert in database

            myConnection.Close();
        }
    }
}
