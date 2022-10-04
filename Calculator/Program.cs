using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                Console.WriteLine("Press 9 for Overloaded Addition");
                Console.WriteLine("Press 0 for Overloaded Subtraction");
                Console.WriteLine("Press 7 to End Calculator App \n ");
                var userInput = Console.ReadLine();

                int subOne = 0;
                int subTwo = 0;

                int addOne = 0;
                int addTwo = 0;


                int[] sumArray = new int[3];

                switch (userInput)
                {
                    case "1":
                        Addition(addOne, addTwo);
                        break;
                    case "2":
                        Subtraction(subOne, subTwo);
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
                    //case "9":
                    //    Addition();
                    //    break;
                    //case "0":
                    //    Subtraction();
                    //    break;

                    case "7":
                        runProgram = false;
                        Console.WriteLine("Program have ended");
                        // Loop stop
                        break;
                }
            }

             static int Addition(int addOne, int addTwo)
            {
                Console.WriteLine("\nEnter the two numbers you want to add: \n");
                addOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("+");
                addTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=");
                int sum = addOne + addTwo;
                Console.WriteLine(sum + "\n");
                return sum;
            }

            //static int Addition(int sumArray)
            //{
            //    Console.WriteLine("\nEnter the three numbers you want to add: \n");
            //    sumArray = Convert.ToInt32(Console.ReadLine());
            //    return sumArray;
            //}

            static int Subtraction(int subOne, int subTwo)
            {
                Console.WriteLine("\nEnter the two numbers you want subtracted: \n");
                subOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-");
                subTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=");
                int sum = subOne - subTwo;
                Console.WriteLine(sum + "\n");
                return sum;
            }

            static int Multiplication()
            {
                Console.WriteLine("\nEnter the two numbers you want multiplied: \n");
                int multiOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("*");
                int multiTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=");
                int sum = multiOne * multiTwo;
                Console.WriteLine(sum + "\n");
                return sum;
            }


            static int Powerof2()
            {
                Console.WriteLine("\nEnter the number you want Squared: \n");
                int powOne = Convert.ToInt32(Console.ReadLine());
                int sum = powOne * powOne;
                Console.WriteLine(sum);
                return sum;
            }

            static int SquareRoot()
            {
                Console.WriteLine("\nEnter the number for the Square Root: \n");
                int sqrt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Math.Sqrt(sqrt).ToString());
                return sqrt;
            }

            static int Division()
            {
                Console.WriteLine("\nEnter the two numbers you want divided: \n");
                int divOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("/");
                int divTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("=");
                int returnValue = 0;
                try
                {
                    int sum = divOne / divTwo;
                    Console.WriteLine(sum + "\n");
                    return sum;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You can't divide by 0");
                    return returnValue;
                }               
            }
        }
    }
}