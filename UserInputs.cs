using System;

namespace Calculator_v8324
{/// <summary>
/// Class for handling of all user inputs
/// </summary>
    internal class UserInputs
    {
        /// <summary>
        /// Asks the user to enter a number, prompts for either num1 or num2 depending on second parameter value. Also passes the previousANswer through in case of 'ans' entry
        /// </summary>
        /// <param name="previousAnswer"></param>
        /// <param name="updateNum"></param>
        /// <returns></returns>
        public static double GetNumber(double previousAnswer, int updateNum)
        {
            
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
            if (input == "ans")
            {
                return previousAnswer;
            }

            return ErrorHandling.ValidateNumber(previousAnswer, input);
        }


        /// <summary>
        /// Asks the user to enter an operator for the calculation, then calls error handling to validate
        /// </summary>
        /// <returns></returns>
        public static string GetOperator()
        {
            Console.WriteLine("Pick one of the following operators: (+ / - * / ^ % root)");

            string input = Console.ReadLine();

            return ErrorHandling.ValidateOperator(input);
        }

        /// <summary>
        /// Asks the user if they would like to perform another calculation
        /// </summary>
        /// <returns></returns>
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
