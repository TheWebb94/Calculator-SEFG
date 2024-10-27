using System;

namespace Calculator_v8324
{
   /// <summary>
   /// Class for handling of all error conditions
   /// </summary>
    internal class ErrorHandling
    {/// <summary>
    /// This takes in the value form GetNumber and checks it is a number that can be stored as a double
    /// </summary>
    /// <param name="previousAnswer"></param>
    /// <param name="input"></param>
    /// <returns></returns>
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

       /// <summary>
       /// Takes in the value given by GetOperator and checks it is valid
       /// </summary>
       /// <param name="input"></param>
       /// <returns></returns>
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

        /// <summary>
        /// Takes in operator and num2 to make sure division by zero is not happening, calls GetNumber2 if fails
        /// </summary>
        /// <param name="operator1"></param>
        /// <param name="number"></param>
        /// <param name="previousAnswer"></param>
        /// <returns></returns>
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


    
