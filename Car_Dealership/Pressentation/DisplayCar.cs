using Car_Dealership.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Pressentation
{
    class DisplayCar
    {
        private int closeOperationId = 6;
        private ProductWork productWork = new ProductWork();
        public DisplayCar()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "CARS" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all cars");
            Console.WriteLine("2. Add new car");
            Console.WriteLine("3. Update car");
            Console.WriteLine("4. Fetch car by ID");
            Console.WriteLine("5. Delete car by ID");
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
            productWork.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Cars car = productWork.Get(id);
            if (car != null)
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + car.IDcar);
                Console.WriteLine("Brand: " + car.Brand);
                Console.WriteLine("Model: " + car.Model);          
                Console.WriteLine(new string('-', 40));
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Cars car = productWork.Get(id);
            if (car != null)
            {
                Console.WriteLine("Enter Brand: ");
                car.Brand = Console.ReadLine();
                Console.WriteLine("Enter Model: ");
                car.Model  = Console.ReadLine();
                productWork.Update(car);
            }
            else
            {
                Console.WriteLine("Cars not found!");
            }
        }

        private void Add()
        {
            Cars car = new Cars();
            Console.WriteLine("Enter Brand: ");
            car.Brand = Console.ReadLine();
            Console.WriteLine("Enter Model: ");
            car.Model = Console.ReadLine();
            
            productWork.Add(car);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "CARS" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var cars = productWork.GetAll();
            foreach (var car in cars)
            {
                Console.WriteLine("{0} {1} {2}", car.IDcar, car.Brand, car.Model);
            }
        }

    }
}

