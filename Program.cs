using Calculator_v8324;
using System;

namespace Calculator_app
{
    internal class Program
    {
        static double num1, num2;
        static string operation;
        private static double previousAnswer;

                // add comments in for readability
                // look at enums for constant values (operands)

                //check recursion when caling self is fine?


        static void Main()
        {
            bool continueCalculating = true;
            while (continueCalculating)
            {
                GetExpressionFromUser();

                NumberIsDivisibleByZero(operation, num2);

                double operationResult = PerformOperation();
                
                OutputExpression(operationResult);

                previousAnswer = operationResult;

                continueCalculating = UserInputs.AskToContinue();

            }
        }

        private static void OutputExpression(double operationResult)
        {
            Console.Write(num1);
            Console.Write(operation);
            if (operation == "root")
            {
                
            } else
            {
                Console.Write(num2);
            }
            Console.Write($"={operationResult}\n");

        }

        private static void GetExpressionFromUser()
        {
            num1 = UserInputs.GetNumber(previousAnswer, 1);
            operation = UserInputs.GetOperator();
            if (operation == "root")
            {
                 
            } else
            {
                num2 = UserInputs.GetNumber(previousAnswer, 2);
            }
        }

        private static double PerformOperation()
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "^":
                    result = Math.Pow(num1, num2);
                    break;
                case "%":
                    result = (num1 / 100) * num2;
                    break;
                case "root":
                    result = Math.Sqrt(num1);
                    break;
            }

            return result;
        }

        public static bool NumberIsDivisibleByZero(string operator1, double number)
        {
            if (operator1 != "/")
            {
                return true;
            }
            else if (number == 0)
            {
                Console.WriteLine("Cannot divide number by zero, enter a valid divisor");
                num2 = UserInputs.GetNumber(previousAnswer, 2);
                return NumberIsDivisibleByZero(operation, num2);
            }
            return true;
        }
    }
}
