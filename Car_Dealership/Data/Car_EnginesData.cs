using Car_Dealership.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Data
{
 public class Car_EnginesData
    {
        public List<Car_Engine> GetAll()
        {
            var Car_EngineList = new List<Car_Engine>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Car_Engine", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var car_Engine = new Car_Engine(
                            reader.GetInt32(0),
                            reader.GetDecimal(1),
                            reader.GetInt32(2),
                            reader.GetString(3)
                        );

                        Car_EngineList.Add(car_Engine);
                    }

                }
                connection.Close();
            }

            return Car_EngineList;
        }

        public Car_Engine Get(int id)
        {
            Car_Engine car_Engine = null;
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT * FROM Car_Engine WHERE IDengine=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        car_Engine = new Car_Engine(
                                reader.GetInt32(0),
                                reader.GetDecimal(1),
                                reader.GetInt32(2),
                                reader.GetString(3)
                        );
                    }
                }

                connection.Close();
            }

            return car_Engine;
        }

        public void Add(Car_Engine car_Engine)
        {
            using (var connection = Database.GetConnection())
            {
                
                var command = new SqlCommand("INSERT INTO Car_Engine (Cubes, HP, Fuel) VALUES( @cubes, @hp,  @fuel)", connection);

                command.Parameters.AddWithValue("cubes", car_Engine.Cubes);
                command.Parameters.AddWithValue("hp", car_Engine.HP);
                command.Parameters.AddWithValue("fuel", car_Engine.Fuel);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void Update(Car_Engine car_Engine)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("UPDATE Car_Engine SET Cubes=@cubes, HP=@hp, Fuel=@fuel WHERE IDengine=@id", connection);
                command.Parameters.AddWithValue("id", car_Engine.IDengine);
                command.Parameters.AddWithValue("cubes", car_Engine.Cubes);
                command.Parameters.AddWithValue("hp", car_Engine.HP);
                command.Parameters.AddWithValue("fuel", car_Engine.Fuel);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

        }

        public void Delete(int id)
        {
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("DELETE Car_Engine WHERE IDengine=@id", connection);
                command.Parameters.AddWithValue("id", id);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            }
        }
    }
}