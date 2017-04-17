using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_11___Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the calculator gg1000.");         

            double firstNumber = firstNumberChoice();
            string operationInput = chosenOperator();
            double secondNumber = secondNumberChoice();
                        
            calculatorMath(operationInput, firstNumber, secondNumber);
            
            Console.WriteLine("\nWould you like to contine?\nPlease enter Yes or No");
            string continueUsingCalculator = Console.ReadLine();

            while (continueUsingCalculator == "Yes" || continueUsingCalculator == "yes")
            {
                firstNumber = firstNumberChoice();
                operationInput = chosenOperator();
                secondNumber = secondNumberChoice();
                
                Console.WriteLine(calculatorMath(operationInput, firstNumber, secondNumber));
                Console.ReadKey();

                Console.WriteLine("\nWould you like to contine?\nPlease enter Yes or No");
                continueUsingCalculator = Console.ReadLine();
            }
            Console.WriteLine("\nThanks for using the gg1000!\n\nShutting Down, Bye!");
            Console.ReadKey();
        }
        static double firstNumberChoice()//Asks for the users first number choice
        {
            Console.WriteLine("Please choose your first number.");
            string firstNumberInput = Console.ReadLine();
            double firstNumber = Convert.ToDouble(firstNumberInput);

            return firstNumber;
        }
        static string chosenOperator()
        {
            Console.WriteLine("Now choose what operation you'd like to perform.\n\n(+) for addition\n(-) for subtraction\n(*) for multiplication\n(/) for division\n(^) for exponential functions\n");
            string operationInput = Console.ReadLine();

            return operationInput;
        }
        static double secondNumberChoice()
        {
            Console.WriteLine("Now choose your second number");
            string secondNumberInput = Console.ReadLine();
            double secondNumber = Convert.ToDouble(secondNumberInput);

            return secondNumber;
        }
        static double? calculatorMath(string operationInput, double firstNumber, double secondNumber)
        {
            double? result;
            switch (operationInput)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "^":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("\nThat wasn't a valid operation for this calculator.");
                    result = null;
                    break;
            }
            Console.WriteLine($"The answer is {result}");
            return result;
        }          
    }
}
