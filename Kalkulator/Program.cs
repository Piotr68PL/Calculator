using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Welcome_Screen
            Console.WriteLine("Welcome to my first calculator. You must type 'none' of the end. For first enter number of numbers, that you want to calculate");
            string num = Console.ReadLine();
            int numofoper = Int32.Parse(num);
            #endregion
            #region Calculation
            int calc = 0;
            for (int i = 0; i < numofoper; i++)
            {
                Console.WriteLine("Enter number");
                string num2 = Console.ReadLine();
                int numint2 = Int32.Parse(num2);
                Console.WriteLine("Choose operation (+, -, *, / or none):");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        calc = numint2 + calc;
                        break;
                    case "-":
                        calc = numint2 - calc;
                        break;
                    case "*":
                        calc = numint2 * calc;
                        break;
                    case "/":
                        calc = numint2 / calc;
                        break;
                    case "none":
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
            Console.WriteLine("Your result is: " + calc);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            #endregion
            

        }
    }
}
