using Calculator_app;
using System;

namespace Calculator_v8324
{
    internal class UserInputs
    {
        public static double GetNumber(double previousAnswer, int updateNum)
        {
            double number;
            switch (updateNum)
            {
                case 1:
                    Console.WriteLine("Enter first number or enter 'ans' to use previous calculation result");
                    break;
                case 2:
                    Console.WriteLine("Enter second number or enter 'ans' to use previous calculation result");
                    break;
                default:
                    break;
            }
            string input = Console.ReadLine();
            if(input == "ans")
            {
                number = previousAnswer;
                return number;
            }
            if (double.TryParse(input, out number))
                {
                    return number;
                }
            else
                {
                    Console.WriteLine("Invalid input, please enter a valid number");
                    return GetNumber(previousAnswer, 1);
                }
        }

        public static string GetOperator()
        {
            while (true)
            {
                Console.WriteLine("Pick one of the following operators: (+ / - * / ^ % root)");
                string input = Console.ReadLine();
            if (input == "+" || input == "-" || input == "*" || input == "/" || input == "^" || input == "%" || input == "root")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid operator chosen. Please enter one of the following: +, -, *, / ^");
            }
            }
        }
        public static bool AskToContinue()
        {

            Console.WriteLine("Would you like to continue calculating? Please enter 'y' or 'n'");

            string input = Console.ReadLine().ToLower();

            if (input == "n")
            {
                return false;
            }
            else if (input == "y")
            {
                return true;
            }
            Console.WriteLine("Invalid choice, please enter 'y' or 'n'.");
            return AskToContinue();
        }

    }
}
