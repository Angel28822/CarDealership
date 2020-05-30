using Car_Dealership.Common;
using Car_Dealership.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Pressentation
{
    class DisplayCarPrice
    {
        private int closeOperationId = 6;
        private CarPriceWork carPriceWork = new CarPriceWork();
        public DisplayCarPrice()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "CONFIGURATIONS CARS & ENGINE" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all cars prices");
            Console.WriteLine("2. Add new car price");
            Console.WriteLine("3. Update car price");
            Console.WriteLine("4. Fetch car price by ID");
            Console.WriteLine("5. Delete car price by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        ListAll();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }
            } while (operation != closeOperationId);
        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            carPriceWork.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Car_Price car_Price = carPriceWork.Get(id);
            if (car_Price != null)
            { //int idprice, int idcar,int idengine, double price
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID Price: " + car_Price.Price);
                Console.WriteLine("Id Car: " + car_Price.IDcar);
                Console.WriteLine("Id Engine: " + car_Price.IDengine);
                Console.WriteLine("Price: " + car_Price.Price);
                Console.WriteLine(new string('-', 40));
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Car_Price car_Price = carPriceWork.Get(id);
            if (car_Price != null)
            {
                Console.WriteLine("Enter Id Car: ");
                car_Price.IDcar = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Id Engine: ");
                car_Price.IDengine = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Price: ");
                car_Price.Price =decimal.Parse(Console.ReadLine());
                carPriceWork.Update(car_Price);
            }
            else
            {
                Console.WriteLine("Engine not found!");
            }
        }

        private void Add()
        {
            Car_Price car_Price = new Car_Price();
            Console.WriteLine("Enter Id Car: ");
            car_Price.IDcar = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Id Engine: ");
            car_Price.IDengine = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price: ");
            car_Price.Price = decimal.Parse(Console.ReadLine());
            carPriceWork.Add(car_Price);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "CAR PRICES" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var get_Cars_Elements = carPriceWork.GetAll();
            foreach (var elem in get_Cars_Elements)
            {//int idprice, string brand, string model, decimal cubes, int hp, string fuel,double price
                Console.WriteLine("{0} {1} {2} {3} {4} HP {5} {6}", elem.IdCars_Elements, elem.Brand, elem.Model, elem.Cubes, elem.HP,elem.Fuel,elem.Price);
            }
        }

    }
}
