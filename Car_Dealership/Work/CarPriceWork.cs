using Car_Dealership.Common;
using Car_Dealership.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Work
{
   public class CarPriceWork
    {
        private Car_PriceData manager = new Car_PriceData();
       private Get_Cars_Elements getElements = new Get_Cars_Elements();
        public List<Cars_Elements> GetAll()
        {
            return getElements.GetAll();
        }

        public Car_Price Get(int id)
        {
            return manager.Get(id);
        }

        public void Add(Car_Price car_Price)
        {
            manager.Add(car_Price);
        }
        
        public void Update(Car_Price car_Price)
        {
            manager.Update(car_Price);
        }

        public void Delete(int id)
        {
            manager.Delete(id);
        }
    }
}
