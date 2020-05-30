using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership
{
    public class Cars
    {

        private int idcar;
        private string brand;
        private string model;
        public int IDcar { get; }
        public string Brand
        {
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Brand connot be empty");
                }
                this.brand  = value;

            }
            get { return this.brand; }
        }
        public string Model { get; set; }

        public Cars()
        {
            
        }

        public Cars(int idcar, string brand, string model)
        {
            this.IDcar = idcar;
            this.Brand = brand;
            this.Model = model;
        }
    }
}
