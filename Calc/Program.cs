using System;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                double number1;
                bool parseResult;
                string input;


                do
                {
                    Console.Write("Enter number 1 please: ");
                    input = Console.ReadLine();
                    parseResult = double.TryParse(input, out number1);
                }
                while (!parseResult);

                double number2;

                Console.Write("Enter number 2 please: ");
                while (!double.TryParse(Console.ReadLine(), out number2))
                {
                    Console.Write("Enter number 2 please: ");
                }


                bool correctOperator;
                do
                {
                    Console.Write("Enter your operation:'+','-','/','*','^','√'");
                    string userInput = Console.ReadLine();
                    correctOperator = true;

                    switch (userInput)
                    {
                        case "+":
                            Console.WriteLine(number1 + number2);
                            break;
                        case "-":
                            Console.WriteLine(number1 - number2);
                            break;
                        case "/":
                            if (number2 == 0)
                            {
                                Console.WriteLine("Invalid operation - (number 2) == 0");
                                correctOperator = false;
                            }
                            else
                            {
                                Console.WriteLine(number1 / number2);
                            }
                            break;
                        case "*":
                            Console.WriteLine(number1 * number2);
                            break;
                        case "^":
                            Console.WriteLine(Math.Pow(number1, number2));
                            break;
                        case "√":
                            Console.WriteLine($"{Math.Sqrt(number1)} and {Math.Sqrt(number2)}");
                            break;
                        default:
                            Console.WriteLine("Invalid operation!");
                            correctOperator = false;
                            break;
                    }
                }
                while (!correctOperator);

                
                Console.WriteLine("Do you want to continue? Y/N");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Y)
                    repeat = true;
                else
                    repeat = false;
                Console.ReadKey();
            }
        }
    }
}
