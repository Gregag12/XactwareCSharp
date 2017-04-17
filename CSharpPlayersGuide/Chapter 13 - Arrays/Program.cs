using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_13___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int scores[];
            // int[] scores = new int [10];
            // string[] names = new string [10];
            // scores[0] = 99;
            // int fourthScore = score[3];
            // int eigthScore = score[7];

            // address = base * index + size

            //int[] scores = new int[10] {100, 95, 92, 87, 55, 50, 48, 35, 10};
            //int[] scores = new int[] {100, 95, 92, 87, 55, 50, 48, 35, 10};
            //int[] scores = new [] {100, 95, 92, 87, 55, 50, 48, 35, 10};

            //int totalThingsInArray = scores.Length;
            //Console.WriteLine($"There are {totalThingsInArray} things in the array");



            //int[] array = new int[] {4, 51,-7, 13, -99, 15, -8, 45, 90};
            //int currentMinimum = Int32.MaxValue;
            //for (int index = 0; index < array.Length; index++)
            //{
            //    if (array[index] < currentMinimum)
            //        currentMinimum = array[index];
            //}



            //int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            //int total = 0;
            //for (int index = 0; index < array.Length; index++)
            //    total += array[index];
            //float average = (float)total / array.Length;
            //Console.WriteLine(average);



            //***** Try It Out - Copying Arrays *****//
            /*
            string[] superheroes = new[] { "Superman", "Batman", "Wonder Woman", "Green Lantern", "Martian ManHunter", "Hawkgirl", "Flash", "Aquaman", "Cyborg", "Green Arrow" };
            string[] copy = new string[superheroes.Length];
            for (int i = 0; i < superheroes.Length; i++)
                copy[i] = superheroes[i];
            foreach (string name in superheroes)
                Console.WriteLine(name);
            foreach (string name in copy)
                Console.WriteLine(name);
            */



            //int[][] matrix = new int[4][];
            //matrix[0] = new int[4];
            //matrix[1] = new int[5];
            //matrix[2] = new int[2];
            //matrix[3] = new int[6];
            //matrix[2][1] = 7;



            //int[,] matrix = new int[4, 4];
            //matrix[0, 0] = 1;
            //matrix[0, 1] = 0;
            //matrix[3, 3] = 1;


            //***** jagged array *****//

            //int[][] matrix = new int[4][];
            //matrix[0] = new int[2];
            //matrix[1] = new int[6];
            //matrix[2] = new int[3];
            //matrix[3] = new int[2];
            //for (int row = 0; row < matrix.Length; row++)
            //{
            //    for (int column = 0; column < matrix[row].Length; column++)
            //        Console.WriteLine(matrix[row][column] + " ");
            //    Console.WriteLine();
            //}

            //***** multi-dimensional array *****//

            //int[,] matrix = new int[4,4];
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int column = 0; column < matrix.GetLength(1); column++)
            //        Console.WriteLine(matrix[row, column] + " ");
            //    Console.WriteLine();
            //}


            //***** foreach loop *****//

            //int[] scores = new int[10];
            //foreach (int score in scores)
            //    Console.WriteLine($"Someone had this score {score}" );



            //***** Try It Out - Minimum and Averaging Revisited *****//

            //int[] array = new int[] {4, 51,-7, 13, -99, 15, -8, 45, 90};
            //int currentMinimum = Int32.MaxValue;
            //for (int index = 0; index < array.Length; index++)
            //{
            //    if (array[index] < currentMinimum)
            //        currentMinimum = array[index];
            //}
            int[] minimumArray = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentMinimum = Int32.MaxValue;
            foreach (int number in minimumArray)
            {
                if(number < currentMinimum) { currentMinimum = number; }
            }
            Console.WriteLine($"Minimum number is {currentMinimum}");

            int total = 0;
            foreach (int number in minimumArray)
            {
                total += number;
            }
            float average = (float)total / minimumArray.Length;
            Console.WriteLine($"Average is {average}");




            Console.ReadKey();
        }
    }
}
