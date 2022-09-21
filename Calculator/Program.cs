using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class Program
    {

        static void Main()
        {
            var runProgram = true;
            while (runProgram)
            // Bool loop initialised
            {
                Console.WriteLine("Calculator Console Application: \n");
                Console.WriteLine("Press 1 for + Addition");
                Console.WriteLine("Press 2 for - Subtraction");
                Console.WriteLine("Press 3 for * Multiplication");
                Console.WriteLine("Press 4 for / Division");
                Console.WriteLine("Press 5 for ^2 Power of Two");
                Console.WriteLine("Press 6 for Square Root");
                Console.WriteLine("Press 7 to End Calculator App \n ");
                var userInput = Console.ReadLine();


                switch (userInput)
                {
                    case "1":
                        Addition();
                        break;
                    case "2":
                        Subtraction();
                        break;
                    case "3":
                        Multiplication();
                        break;
                    case "4":
                        Division();
                        break;
                    case "5":
                        Powerof2();
                        break;
                    case "6":
                        SquareRoot();
                        break;
                    case "7":
                        runProgram = false;
                        Console.WriteLine("Program have ended");
                        // Loop stop
                        break;
                }
            }

            void Addition()
            {
                Console.WriteLine("\nEnter the two numbers you want to add: \n");
                int addOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("+");
                int addTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=");
                int sum = addOne + addTwo;
                Console.WriteLine(sum + "\n");
            }

            void Subtraction()
            {
                Console.WriteLine("\nEnter the two numbers you want subtracted: \n");
                int subOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-");
                int subTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=");
                int sum = subOne - subTwo;
                Console.WriteLine(sum + "\n");
            }

            void Multiplication()
            {
                Console.WriteLine("\nEnter the two numbers you want multiplied: \n");
                int multiOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*");
                int multiTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=");
                int sum = multiOne * multiTwo;
                Console.WriteLine(sum + "\n");
            }


            void Powerof2()
            {
                Console.WriteLine("\nEnter the number you want Squared: \n");
                int powOne = Convert.ToInt32(Console.ReadLine());
                int sum = powOne * powOne;
                Console.WriteLine(sum);
            }

            void SquareRoot()
            {
                Console.WriteLine("\nEnter the number for the Square Root: \n");
                int sqrt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(sqrt).ToString());
            }

            void Division()
            {
                Console.WriteLine("\nEnter the two numbers you want divided: \n");
                int divOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("/");
                int divTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=");
                try
                {
                    int sum = divOne / divTwo;
                    Console.WriteLine(sum + "\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You can't divide by 0");
                }

            }
        }
    }
}