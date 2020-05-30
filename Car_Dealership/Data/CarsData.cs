using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Data
{
  public class CarsData
    {
        //Клас за работа с таблица Cars от базата данни
        public List<Cars> GetAll()
        {
            var carsList = new List<Cars>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM cars", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cars = new Cars(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2)
                        );

                        carsList.Add(cars);
                    }

                }
                connection.Close();
            }

            return carsList;
        }

        public Cars Get(int id)
        {
            Cars cars = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM cars WHERE IDCar=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cars = new Cars(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2)
                        );
                    }
                }

                connection.Close();
            }

            return cars;
        }

        public void Add(Cars cars)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("INSERT INTO Cars (Brand, Model) VALUES( @brand,  @model)", connection);
                command.Parameters.AddWithValue("brand", cars.Brand);
                command.Parameters.AddWithValue("model", cars.Model);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Cars cars)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("UPDATE cars SET Brand=@brand, Model=@model WHERE IDcar=@id", connection);
                command.Parameters.AddWithValue("id", cars.IDcar);
                command.Parameters.AddWithValue("brand", cars.Brand);
                command.Parameters.AddWithValue("model", cars.Model);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        public void Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE cars WHERE IDCar=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}