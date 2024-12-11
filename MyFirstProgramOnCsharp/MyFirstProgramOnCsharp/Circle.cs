using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class Circle
    {

        public static void AreaAndPerimeter()
        {
            Console.Write("Enter the diameter of circle :");
            int diameter = Int32.Parse(Console.ReadLine());
            double radius = diameter / 2;
            Console.WriteLine($"Area of circle is {Math.PI * Math.Pow(radius, 2)}");
            Console.WriteLine($" perimeter of circle is {2 * Math.PI * radius}");

        }

    }
}
