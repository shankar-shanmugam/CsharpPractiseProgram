using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class NumberFactor
    {

        public static void FindNumberString()
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = "";

            if (number % 3 == 0)
            {
                result += "Pling";
            }
            if (number % 5 == 0)
            {
                result += "Plang";
            }
            if (number % 7 == 0)
            {
                result += "Plong";
            }
            if (result == "")
            {
                result = number.ToString();  
            }
            Console.WriteLine(result);
        }

    }
}
