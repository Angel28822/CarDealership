using Car_Dealership.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Work
{
  public class ProductWork
    {
        private CarsData manager = new CarsData();

        public List<Cars> GetAll()
        {
            return manager.GetAll();
        }

        public Cars Get(int id)
        {
            return manager.Get(id);
        }

        public void Add(Cars car)
        {
            manager.Add(car);
        }

        public void Update(Cars car)
        {
            manager.Update(car);
        }

        public void Delete(int id)
        {
            manager.Delete(id);
        }
    }
}
