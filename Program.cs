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

                ErrorHandling.ValidateDivisor(operation, num2, previousAnswer);

                double operationResult = PerformOperation();
                
                OutputExpression(operationResult);

                previousAnswer = operationResult;

                continueCalculating = UserInputs.AskToContinue();
            }
        }

        //prints out the expression with result
        private static void OutputExpression(double operationResult)
        {
            Console.Write(num1 + " " + operation + " ");
            if (operation == "root")
            {
                
            } else
            {
                Console.Write(num2);
            }
            Console.Write($" = {operationResult}\n");
        }

        //gets all user values
        private static void GetExpressionFromUser()
        {2342324
            num1 = UserInputs.GetNumber(previousAnswer, 1);
            operation = UserInputs.GetOperator();
            if (operation == "root")
            {
                 
            } 
            else
            {
                num2 = UserInputs.GetNumber(previousAnswer, 2);
            }
        }

        // perform the calcuulation from user values
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
    }
}
