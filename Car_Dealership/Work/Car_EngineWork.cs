using Car_Dealership.Common;
using Car_Dealership.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Work
{
   public class Car_EngineWork
    {
        private Car_EnginesData manager = new Car_EnginesData();

        public List<Car_Engine> GetAll()
        {
            return manager.GetAll();
        }

        public Car_Engine Get(int id)
        {
            return manager.Get(id);
        }

        public void Add(Car_Engine car_Engine)
        {
            manager.Add(car_Engine);
        }

        public void Update(Car_Engine car_Engine)
        {
            manager.Update(car_Engine);
        }

        public void Delete(int id)
        {
            manager.Delete(id);
        }
    }
}