using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_10___Decision_Making
{
    class Program
    {
        static void Main(string[] args)
        {
            //First part of decision making
            /*
            Console.WriteLine("Enter score");
            string scoreAsText = Console.ReadLine();
            int score = Convert.ToInt32(scoreAsText);

            if (score == 100)
            {
                Console.WriteLine("Perfect Score");
            }
            else if (score == 99)
            {
                Console.WriteLine("Missed it by THAT much");
            }
            else if (score == 0)
            {
                Console.WriteLine("Were you trying to get that bad of a score?");
            }
            else
            {
                Console.WriteLine("Dang. Not perfect. You loose");
            }
            */

            /*
            Console.WriteLine("Enter your score");
            string scoreAsText = Console.ReadLine();
            int score = Convert.ToInt32(scoreAsText);

            if (score >= 90)
            {
                Console.WriteLine("Great work! You get an A!!");
            }
            else if (score >=80)
            {
                Console.WriteLine("Good job. You get a B");
            }
            else if (score >=70)
            {
                Console.WriteLine("You got a C. Keep trying!");
            }
            else if (score >= 60)
            {
                Console.WriteLine("You got a D. You can do better.");
            }
            else 
            {
                Console.WriteLine("You got a F. That's a failing grade");
            }
            */


            /*
            int score = 45;
            int pontsNeededToPass = 100;
            bool levelComplete = (score >= pontsNeededToPass);

            if (levelComplete)
            Console.WriteLine("Well done!");
            */


            /*Console.WriteLine("Let's see if a number is odd or even.\n\nPick a number");
            string userNumberAsText = Console.ReadLine();
            int userNumber = Convert.ToInt32(userNumberAsText);
            int answer = userNumber % 2;
            bool oddEven = (answer != 0);

            if (oddEven)
            {
                Console.WriteLine($"Hmmm. Interesting.\n {userNumber} is an odd number!");
            }
            else
                Console.WriteLine($"Let me do some math.\n {userNumber} was even");
           */

            Console.WriteLine("\nWant to play a game?\n\nYes or No");
            string inputAnswer = Console.ReadLine();

            if (inputAnswer == "Yes" || inputAnswer == "yes")
                playGame();
            else
                endGame();           
        }
        static void playGame()
        {
            Console.WriteLine("\nPick two numbers, either positive or negative and I'll you if you multiply them together what the product will be.\n\nThe answer will be positive or negative, not the actual product.");

            Console.WriteLine("\nWhat is your first number?");
            string inputFirstNumber = Console.ReadLine();
            int firstNumber = Convert.ToInt32(inputFirstNumber);

            Console.WriteLine("\nAnd the Second number?");
            string inputSecondNumber = Console.ReadLine();
            int secondNumber = Convert.ToInt32(inputSecondNumber);

            if (firstNumber < 0)
                if (secondNumber < 0)
                    Console.WriteLine($"\nThe product of {firstNumber} and {secondNumber} would be positive");
                else if (secondNumber > 0)
                    Console.WriteLine($"\nThe product of {firstNumber} and {secondNumber} would be negative");
                else
                    Console.WriteLine($"\nThe product of {firstNumber} and {secondNumber} would be zero");
            else if (firstNumber > 0)
                if (secondNumber < 0)
                    Console.WriteLine($"\nThe product of {firstNumber} and {secondNumber} would be negative");
                else if (secondNumber > 0)
                    Console.WriteLine($"\nThe product of {firstNumber} and {secondNumber} would be positive");
                else
                    Console.WriteLine("\nThe product would be zero");
            else
                Console.WriteLine("\nThe product would be zero");


            Console.WriteLine("\n\nWant to try it some more?\nYes or No?");
            string tryAgain = Console.ReadLine();
            if (tryAgain == "Yes" || tryAgain == "yes")
                playGame();
            else
                endGame();
            
        }
        static void endGame()
        {
            Console.WriteLine("You're choice.\nBye!");
            Console.ReadKey();
        }

    }
}

