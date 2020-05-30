using Car_Dealership.Common;
using Car_Dealership.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership.Pressentation
{
    class DisplayEngine
    {
        private int closeOperationId = 6;
        private Car_EngineWork car_EngineWork = new Car_EngineWork();
        public DisplayEngine()
        {
            Input();
        }

        private void ShowMenu()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 18) + "ENGINE" + new string(' ', 18));
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("1. List all engines");
            Console.WriteLine("2. Add new engine");
            Console.WriteLine("3. Update engine");
            Console.WriteLine("4. Fetch engine by ID");
            Console.WriteLine("5. Delete engine by ID");
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
            car_EngineWork.Delete(id);
            Console.WriteLine("Done.");
        }

        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            Car_Engine car_Engine = car_EngineWork.Get(id);
            if (car_Engine != null)
            { 
                Console.WriteLine(new string('-', 40));
                Console.WriteLine("ID: " + car_Engine.IDengine);
                Console.WriteLine("Cubes: " + car_Engine.Cubes);
                Console.WriteLine("HP: " + car_Engine.HP);
                Console.WriteLine("Fuel: " + car_Engine.Fuel);
                Console.WriteLine(new string('-', 40));
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            Car_Engine car_Engine = car_EngineWork.Get(id);
            
            if (car_Engine != null)
            {   
                Console.WriteLine("Enter Cubes: ");
                car_Engine.Cubes = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter HP: ");
                car_Engine.HP = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Fuel: ");
                car_Engine.Fuel = Console.ReadLine();
                car_EngineWork.Update(car_Engine);
            }
            else
            {
                Console.WriteLine("Engine not found!");
            }
        }

        private void Add()
        { 
            Car_Engine car_Engine = new Car_Engine();
         
            Console.WriteLine("Enter Cubes: ");
            car_Engine.Cubes = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter HP: ");
            car_Engine.HP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fuel: ");
            car_Engine.Fuel = Console.ReadLine();
            car_EngineWork.Add(car_Engine);
        }

        private void ListAll()
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine(new string(' ', 16) + "ENGINE" + new string(' ', 16));
            Console.WriteLine(new string('-', 40));
            var engines = car_EngineWork.GetAll();
            foreach (var  engine in engines)
            {
                Console.WriteLine("{0} {1} {2} HP {3}", engine.IDengine, engine.Cubes, engine.HP,engine.Fuel);
            }
        }

    }
}
