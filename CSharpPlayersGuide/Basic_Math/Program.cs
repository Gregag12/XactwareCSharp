using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //The formula for the area of a circle is pi*r^2
            float radius = 4;
            float π = 3.1415926536f;
            float area = π * radius * radius;
            Console.WriteLine("The area of the circle is " + area + ".");

            //The formula for the area of a triangle is A=1/2bh
            
            float b = 5;
            float h = 6;
            float A = (b * h)/2;

            Console.WriteLine("The area of the triangle is " + A + ".");
            

            //Remainder challenge
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            int workCheck = b * quotient + remainder;
            Console.WriteLine("If " + a + "/" + b + " then the remainder would be " + remainder);
            Console.WriteLine(workCheck);

            //User Input section
            Console.WriteLine("Pick a number");
            string userInput = Console.ReadLine();
            Console.ReadLine();
            */

            //Cylinders: A complete program
            //  Math equations:
            //  Volume of a cylinder: V = πr^2h
            //  Surface Area of a cylinder: SA = 2πr(r+h)
            Console.WriteLine("Let's figure out the volume and surface area of a cylinder. First thing we will do is choose some measurements of our cylinder...");
            Console.WriteLine("How tall should we make it?");
            string height = Console.ReadLine();

            Console.WriteLine("Alright. And how wide should the base of the cylinder be?");
            string diameter = Console.ReadLine();

            Console.WriteLine("What unit of measurement should we do?");
            string unitMeasurement = Console.ReadLine();

            Console.WriteLine("Cool, Cool. Let's do some math!");
            double heightCylinder = Convert.ToDouble(height);
            double diameterCylinder = Convert.ToDouble(diameter);
            float π = 3.1415926f;
            double radius = diameterCylinder / 2;
            double volumeCylinder = π * (radius * radius) * heightCylinder;
            double surfaceArea = 2 * π * radius * (radius + heightCylinder);
            Console.ReadKey();
            Console.WriteLine("The Volume of a cylinder is calculated by taking π * radius squared * height ");
            Console.ReadKey();
            Console.WriteLine("For our cylinder, it's volume is " + volumeCylinder + " " + unitMeasurement + "^3");
            Console.ReadKey();
            Console.WriteLine("The Surface Area of a cylinder is calculate by taking the radius and adding it to the height. That answer is then muliplied by 2 * π * radius");
            Console.ReadKey();
            Console.WriteLine("For our cylinder, it's surface area is " + surfaceArea + " " + unitMeasurement + "^2");
            Console.ReadKey();
            Console.WriteLine("Great Work!");
            Console.ReadKey();

        }
    }
}
