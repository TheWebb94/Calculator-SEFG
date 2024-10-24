using System;

namespace Calculator_v8324
{
    internal class UserInputs
    {

        //Gets number from user, branch for either number one or two (DIV/0 error comes back to this method so needed it to be clear which number is being requested)
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


        //Gets operation from user
        public static string GetOperator()
        {
            Console.WriteLine("Pick one of the following operators: (+ / - * / ^ % root)");

            string input = Console.ReadLine();

            return ErrorHandling.ValidateOperator(input);
        }

        //Asks the user if they want to perform another calculation
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
