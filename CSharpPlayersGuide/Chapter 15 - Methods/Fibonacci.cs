using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_15___Methods
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(fibonacciMethod(i));
            }
            Console.ReadKey();

        }
        static int fibonacciMethod(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
    
}

