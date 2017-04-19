//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chapter_15___Methods
//{
//    class Reversing_An_Array
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Choose how many numbers you'd like to be in the array\n");

//            int[] reverseArray = GetNumbers();
//            Reverse(reverseArray);
//            PrintNumbers(reverseArray);
//            Console.ReadKey();
//        }
//        static int[] GetNumbers()
//        {
//            string userInput = Console.ReadLine();
//            int numberCount = Convert.ToInt32(userInput);
//            Console.WriteLine("\nThis is that the array looks like when it's printed forwards and backwards\n");

//            int[] originalArray = new int[numberCount];

//            for (int inputedNumber = 0; inputedNumber < originalArray.Length; inputedNumber++)
//                originalArray[inputedNumber] = inputedNumber + 1;
//            foreach (int number in originalArray)
//                Console.Write(number + "  ");
//            Console.WriteLine();
//            return originalArray;
//        }
//        static int[] Reverse(int[] reverseArray)
//        {
//            int firstIndex = 0;
//            int secondIndex = reverseArray.Length - 1;

//            while (firstIndex < secondIndex)
//            {
//                int temp = reverseArray[firstIndex];
//                reverseArray[firstIndex] = reverseArray[secondIndex];
//                reverseArray[secondIndex] = temp;

//                firstIndex++;
//                secondIndex--;

//            }
//            return reverseArray;
//        }
//        static void PrintNumbers(int[] reverseArray)
//        {
//            for (int index = 0; index < reverseArray.Length; index++)
//            {
//                Console.Write(reverseArray[index] + "  ");
//            }
//            Console.WriteLine();

//        }
//    }
//}
