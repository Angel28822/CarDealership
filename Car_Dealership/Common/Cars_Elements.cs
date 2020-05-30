using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Common
{
  public class Cars_Elements
    {
        private int  idCars_Elements;
        private string brand;
        private string model;
        private decimal cubes;
        private int hp;
        private string fuel;
        private decimal price;

        public int IdCars_Elements { get; }

        public decimal Cubes { get; set; }
        public int HP { get; set; }
        public string Fuel { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public Cars_Elements()
        {
        }
        
        public Cars_Elements(int idprice, string brand, string model, decimal cubes, int hp, string fuel, decimal price)
        {
            this.IdCars_Elements = idprice;
            this.Brand = brand;
            this.Model = model;
            this.Cubes = cubes;
            this.HP = hp;
            this.Fuel = fuel;
            this.Price = price;
        }
    }
}
