using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_12___Looping
{
    class FizzBuzz
    {
        static void Main(string[] args)
        {

            //Things needed in a for loop = for(initial condition; condition to check; action at end of loop)

            //for (int row = 0; row < 5; row++)
            //{
            //    for (int column = 0; column < 10; column++)
            //        Console.Write("*");
            //    Console.WriteLine(); // This makes it wrap around to the beginning of the line.

            //}
            //Console.ReadKey();

            for (int number = 1; number < 101; number++)
            {
                if (number % 3 == 0 && number % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (number % 5 == 0)
                    Console.WriteLine("Buzz");
                else if (number % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
