using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class QuadraticEquation
    {
        public static void FindRoots()
        {
            Console.Write("Enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Calculate the discriminant
            double discriminant = b * b - 4 * a * c;

            // Use if-else statement to determine the type of roots
            if (discriminant > 0)
            {
                // Two real and distinct roots
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The roots are real and distinct.");
                Console.WriteLine("Root 1 = " + root1);
                Console.WriteLine("Root 2 = " + root2);
            }
            else if (discriminant == 0)
            {
                // One real root
                double root = -b / (2 * a);
                Console.WriteLine("The root is real and repeated.");
                Console.WriteLine("Root = " + root);
            }
            else
            {
                // Complex roots
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
                Console.WriteLine("The roots are complex and imaginary.");
                Console.WriteLine("Root 1 = " + realPart + " + " + imaginaryPart + "i");
                Console.WriteLine("Root 2 = " + realPart + " - " + imaginaryPart + "i");
            }
        }

    }

}




