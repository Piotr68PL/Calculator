using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Welcome_Screen
            Console.WriteLine("Welcome to my first calculator. For first enter number of numbers, that you want to calculate");
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
                if (numofoper != i+1)
                {
                    Console.WriteLine("Choose operation (+, -, *, /):");
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
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }
                }
            }
            #endregion
            #region Result
            Console.WriteLine("Your result is: " + calc);
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            #endregion


        }
    }
}
