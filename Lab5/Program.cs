using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)

        {
            long inputNumber;
            string userChoice = "y";

            Console.WriteLine("Welcome to the factorial calculator!\n");

            while (userChoice.ToLower() == "y")
                


            {
               //user input
                Console.WriteLine("Please enter an integer that's greater than 0 but less than 10.\n");
                string input = Console.ReadLine();
                 //valid input

                if (input.Length == 0) continue;
                inputNumber = long.Parse(input);

                //invalid input

                if (inputNumber >= 10 || inputNumber < 1)
                {

                    Console.WriteLine("Invalid input!\n");
                    continue;
                }
                //for loop
                long factorial = 1;
                for (long i = inputNumber; i > 0; i--)
                {
                    factorial = factorial * i;
                }

                //output
                Console.WriteLine("The factorial of " + inputNumber + " = " + factorial);

                Console.Write("Do you want to continue? (y/n) ");
                userChoice = Console.ReadLine();
                
                               

                              
                                          


            }
        }
    }
}
