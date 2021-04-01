using System;
using System.Collections.Generic;

namespace Example1
{
    class Program
    {
        static void Main(string[] args) //don't put a method in a method
        {
            List<double> gpas = new List<double>();
            List<double> itemPrices = new List<double>();
            string response = "";
            bool shouldLoopAgain = true;

            while (shouldLoopAgain)
            {
                double gpa = ValidateInputIsADouble("Please enter a GPA >>");
                gpas.Add(gpa);

                shouldLoopAgain = DoesTheUserWantToGoAgain();
                Console.WriteLine("Do you want to enter another GPA? Yes or no >>");
                response = Console.ReadLine();

            }

            response = "";
            while (shouldLoopAgain)
            {
                double itemPrice = ValidateInputIsADouble("Please enter a price of an item >>");
                itemPrices.Add(itemPrice);

                shouldLoopAgain = DoesTheUserWantToGoAgain();
                Console.WriteLine("Do you want to enter another price of an item? Yes or no >>");
                response = Console.ReadLine();

            }
        }
        /// <summary>
        /// Determines whether the user has more input to enter
        /// </summary>
        /// True if answered 
        /// False
        /// <returns></returns>
        private static bool DoesTheUserWantToGoAgain()
        {
            string answer;
            bool shouldContinue;

            Console.WriteLine("Do you want to enter another value? Yes or no >>");
            answer = Console.ReadLine();
            while (answer.ToLower() != "no" && answer.ToLower() != "yes")
            {
                Console.WriteLine("You must enter the word 'yes' or 'no'.");
                Console.WriteLine("Do you want to enter another value? Yes or no >>");
                answer = Console.ReadLine();

            }

            if (answer.ToLower() == "no")
            {
                shouldContinue = false;
                //return false;
            }
            else
            {
                shouldContinue = true;
                //return true;
            }

            return shouldContinue;
        }


        /// <summary>
        /// Validates the user gives a valud double response for the question
        /// </summary>
        /// <param name="message">The question to ask the user</param>
        /// <returns>A valid double response</returns>
        static double ValidateInputIsADouble(string message)
        {
            double value;
            string answer;
            
            do
            {
                Console.WriteLine(message);
                answer = Console.ReadLine();

                //bool isADouble = double.TryParse(answer, out value);
            } while (double.TryParse(answer, out value) == false);
            

            return value;
        }

    }
}
