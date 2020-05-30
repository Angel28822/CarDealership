using Car_Dealership.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Data
{
  public class Get_Cars_Elements
    {
        public List<Cars_Elements> GetAll()
        {
            var cars_ElementsList = new List<Cars_Elements>();
            using (var connection = Database.GetConnection())
            {
                var command = new SqlCommand("SELECT Car_Price.IdPrice, Cars.Brand, Cars.Model, " +
                                             "Car_Engine.cubes, Car_Engine.HP, Car_Engine.Fuel, " +
                                             "Car_Price.Price FROM Car_Price join Cars on Car_Price.IDcar=Cars.IDcar " +
                                             "join Car_Engine on Car_Price.IDengine=Car_Engine.IDengine ", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var grades = new Cars_Elements(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetDecimal(3),
                            reader.GetInt32(4),
                            reader.GetString(5),
                            reader.GetDecimal(6)
                        );

                        cars_ElementsList.Add(grades);
                    }

                }
                connection.Close();
            }

            return cars_ElementsList;
        }

    }
}
