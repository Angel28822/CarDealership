using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Common
{
    public class Car_Engine
    { 
        private int idengine;
        private decimal cubes;
        private int hp;
        private string fuel;

        public int IDengine { get; }
        public decimal Cubes { get; set; }
        public int HP { get; set; }
        public string Fuel { get; set; }

        public Car_Engine()
        {

        }

        public Car_Engine(int idengine, decimal cubes, int hp, string fuel)
        {
            this.IDengine = idengine;
            this.Cubes = cubes;
            this.HP = hp;
            this.Fuel = fuel;
        }
    }
}
