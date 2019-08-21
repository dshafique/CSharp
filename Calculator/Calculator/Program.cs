using System;

namespace Calculator
{

    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;

                case "s":
                    result = num1 - num2;
                    break;

                case "m":
                    result = num1 * num2;
                    break;

                case "d":
                    if (num2!=0)
                    {

                        result = num1 / num2;

                    }                    
                    break;

                default:
                    break;

            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console Calculator in C#\nDaoud Shafique - V2\r");
            Console.WriteLine("---------------------------------------------\n");

            while (!endApp)
            {
                string num1input = "";
                string num2input = "";
                double result = 0;

                Console.Write("type a number, and then press enter: ");
                num1input = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(num1input, out cleanNum1))
                {
                    Console.WriteLine("Wrong input, try again: ");
                    num1input = Console.ReadLine();
                }

                Console.Write("type a number, and then press enter: ");
                num2input = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(num2input, out cleanNum2))
                {
                    Console.WriteLine("Wrong input, try again: ");
                    num2input = Console.ReadLine();
                }

                Console.WriteLine("Choose one of the following: ");
                Console.WriteLine("\ta - add ");
                Console.WriteLine("\ts - subtract ");
                Console.WriteLine("\tm - multiply ");
                Console.WriteLine("\td - divide ");
                Console.Write("type your choice:");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("error");
                    }
                    else Console.WriteLine("Your result: {0.0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("math exception. \nDetails: " + e.Message);
                }

                Console.WriteLine("---------------------------------------\n");

                Console.Write("Press 'n' and Enter to close the app, or press any other key and enter to continue");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n");
            }

            return;

        }
    }
}
