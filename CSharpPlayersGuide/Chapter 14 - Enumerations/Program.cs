using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_14___Enumerations
{
    public enum DaysOfWeek {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};
    public enum MonthsOfYear { January=1, February=2, March=3, April=4, May=5, June=6, July=7, August=8, September=9, October=10, November=11, December=12}

    class Program
    {
        static void Main(string[] args)
        {
            //int dayOfWeek = 3;
            //if(dayOfWeek == 3)
            //Console.WriteLine("It's Tuesday!");

            //int sunday = 1;
            //int monday = 2;
            //int tuesday = 3;
            //int wednesday = 4;
            //int thursday = 5;
            //int friday = 6;
            //int saturday = 7;

            //int dayOfWeek = tuesday;
            //if (dayOfWeek == "tuesday")
            //Console.WriteLine("It's Tuesday!");

            //DaysOfWeek today;
            //today = DaysOfWeek.Tuesday;
            //if (today == DaysOfWeek.Tuesday)
            //Console.WriteLine("Taco Tuesday!");

            Console.WriteLine("Please choose a number between 1 and 12");
            string userInput = Console.ReadLine();
           
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You chose the month of January.");
                    break;
                case "2":
                    Console.WriteLine("You chose the month of February.");
                    break;
                case "3":
                    Console.WriteLine("You chose the best month of the year...March!");
                    break;
                case "4":
                    Console.WriteLine("You chose the month of April.");
                    break;
                case "5":
                    Console.WriteLine("You chose the month of May.");
                    break;
                case "6":
                    Console.WriteLine("You chose the month of June.");
                    break;
                case "7":
                    Console.WriteLine("You chose the month of July.");
                    break;
                case "8":
                    Console.WriteLine("You chose the month of August.");
                    break;
                case "9":
                    Console.WriteLine("You chose the month of September.");
                    break;
                case "10":
                    Console.WriteLine("You chose the month of October.");
                    break;
                case "11":
                    Console.WriteLine("You chose the month of November.");
                    break;
                case "12":
                    Console.WriteLine("You chose the month of December.");
                    break;
                default:
                    Console.WriteLine("That wasn't a valid option");
                    break;
                    
            }
           
            Console.ReadKey();
        }
    }
}
