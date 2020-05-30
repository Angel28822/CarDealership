using Car_Dealership.Data;
using Car_Dealership.Pressentation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Dealership
{
    class Program
    {
        static int closeOperationId = 4;
        static void ShowMenu()
            {
                Console.WriteLine(new string('-', 40));
                Console.WriteLine(new string(' ', 18) + "MENU" + new string(' ', 18));
                Console.WriteLine(new string('-', 40));
            
                Console.WriteLine("1. Cars");
                Console.WriteLine("2. Engine");
                Console.WriteLine("3. Configurations Cars & Engine");
                Console.WriteLine("4. Exit");
            }
        static void Input()
        {
            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        DisplayCar d = new DisplayCar();
                        break;
                    case 2:
                        DisplayEngine de = new DisplayEngine();
                        break;
                    case 3:
                        DisplayCarPrice dcp = new DisplayCarPrice();
                        break;
                } 
            } while (operation != closeOperationId);
        }
        
        
        static void Main(string[] args)
        {

            Input();
            
        }
    }
}
