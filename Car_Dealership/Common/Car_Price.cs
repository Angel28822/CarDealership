using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Common
{
   public class Car_Price
    {
        private int idprice;
        private int idcar;
        private int idengine;
        private decimal  price;

        public int IdPrice { get;  }
        public int IDcar { get; set; }
        public int IDengine { get; set; }
        public decimal Price { get; set; }


        public Car_Price()
        {

        }

        public Car_Price(int idprice, int idcar,int idengine, decimal  price)
        {
            this.IdPrice  = idprice;
            this.IDcar  = idcar;
            this.IDengine = idengine ;
            this.Price  = price;
        }

    }
}
