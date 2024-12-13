using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class StringOperation
    {

        public static void UpperAndLower()
        {
            Console.Write("ENTER YOUR FAV FRIEND NAME :");
            String name = Console.ReadLine();

            Console.WriteLine($"{name} in uppercase :{name.ToUpper()}");
            Console.WriteLine($"{name} in lowercase :{name.ToLower()}");

        }

        public static void PrintNumberAsString()
        {
            Console.Write("Enter the number :");
            String number = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number);
            }
        }

        public static void CountNamePartsAndDisplay(String[] args)
        {
            String s = String.Join(" ", args);// it is used to join(concatenate) args[0],arg[1] into single string with delimiter(" ")
            String[] names = s.Split(" ");
            Console.WriteLine($"number of parts in the string is {names.Length}");
            StringBuilder stringBuilder = new StringBuilder();
            foreach (String name in names)
            {
                stringBuilder.Append(name);
            }
            Console.WriteLine($"total parts appended in one variable is {stringBuilder}");
        }
        static void StringPresence()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            bool hasA = input.Contains('a');
            bool hasE = input.Contains('e');
            bool hasP = input.Contains('p');

            if (hasA && hasE && hasP)
            {
                Console.WriteLine("All Present");
            }
            else if (hasA || hasE || hasP)
            {
                Console.WriteLine("One or more - Present");
            }
            else
            {
                Console.WriteLine("None Present");
            }
        }
    }
}



