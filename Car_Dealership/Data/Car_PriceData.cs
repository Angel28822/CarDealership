using Car_Dealership.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Data
{   //Клас за достъп до таблицата Car_Price от базата данни
    public class Car_PriceData
    {
        public void Add(Car_Price car_Price)
        {
            using (var connection = Database.GetConnection())
            {                                                                                     
                var command = new SqlCommand("INSERT INTO Car_Price (IDcar, IDengine, Price) VALUES(@idcar, @idengine,  @price)", connection);
                command.Parameters.AddWithValue("idcar", car_Price.IDcar);
                command.Parameters.AddWithValue("idengine", car_Price.IDengine);
                command.Parameters.AddWithValue("price", car_Price.Price);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public Car_Price Get(int id)
        {
            Car_Price car_Price = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Car_Price  WHERE IdPrice=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
          
                    {
                        car_Price = new Car_Price(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetInt32(2),
                                reader.GetDecimal(3)
                        );
                    }
                }

                connection.Close();
            }

            return car_Price;
        }


        public void Update(Car_Price car_Price)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("UPDATE Car_Price SET IDcar=@idcar, IDengine=@idengine, Price=@price WHERE IdPrice=@id", connection);
                command.Parameters.AddWithValue("id", car_Price.IdPrice);
                command.Parameters.AddWithValue("idcar", car_Price.IDcar);
                command.Parameters.AddWithValue("idengine", car_Price.IDengine);
                command.Parameters.AddWithValue("price", car_Price.Price);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        public void Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE Car_Price WHERE IdPrice=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
        }
}
