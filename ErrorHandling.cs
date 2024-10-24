using System;

namespace Calculator_v8324
{
    //Handles incorrect inputs when user is giving number
    internal class ErrorHandling
    {
        public static double ValidateNumber(double previousAnswer, string input)
        {
            double number;
            if (double.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number");

                return UserInputs.GetNumber(previousAnswer, 0); 
            }
        }

        //Handles incorrect inputs for operator
        public static string ValidateOperator(string input)
        {
            if (input == "+" || input == "-" || input == "*" || input == "/" || input == "^" || input == "%" || input == "root")
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid operator chosen.");

                return UserInputs.GetOperator(); 
            }
        }

        //Error handling for division by zero errors
        public static double ValidateDivisor(string operator1, double number, double previousAnswer)
        {
            if (operator1 != "/")
            {
                return number; 
            }
            else if (number == 0)
            {
                Console.WriteLine("Cannot divide by zero. Please enter a valid divisor:");

                return UserInputs.GetNumber(previousAnswer, 2); 
            }

            return number; 
        }
    }
}


    
