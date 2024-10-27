using Calculator_v8324;
using System;

namespace Calculator_app
{
    internal class Program
    {
        static double num1, num2;
        static string operation;
        private static double previousAnswer;

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

        /// <summary>
        /// Outputs the calculated expression
        /// </summary>
        /// <param name="operationResult"></param>
        private static void OutputExpression(double operationResult)
        {
            Console.Write(num1 + " " + operation + "");

            if (operation == "root")
            {
                
            } else
            {
                Console.Write(num2);
            }

            Console.Write($" = {operationResult}\n");
        }

       /// <summary>
       /// Consolidates the GetNumber method with the GetOperator method for a cleaner main method
       /// </summary>
        private static void GetExpressionFromUser()
        {
            num1 = UserInputs.GetNumber(previousAnswer, 1);

            operation = UserInputs.GetOperator();
            //Only prompts for num2 if root is not being used
            if (operation == "root")
            {
                 
            } 
            else
            {
                num2 = UserInputs.GetNumber(previousAnswer, 2);
            }
        }

        /// <summary>
        /// Calculates the expression
        /// </summary>
        /// <returns></returns>
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
