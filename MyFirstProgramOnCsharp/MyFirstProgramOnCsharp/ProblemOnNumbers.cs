using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class ProblemOnNumbers
    {

        public static void SumAndDiffOfSquareOfTwoNumbers()
        {
            
            Console.Write("Enter the first number: "); //write() - like print() in java which makes cursor present in same line
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;
            double squareOfSum = Math.Pow(sum, 2);

            double difference = number1 - number2;
            double squareOfDifference = Math.Pow(difference, 2);

            Console.WriteLine($"Square of the sum ({number1} + {number2})^2: {squareOfSum}"); // $ is used to for interpolation(you can integrate values or expression directly into string)
            Console.WriteLine($"Square of the difference ({number1} - {number2})^2: {squareOfDifference}");
        }


        public static void AverageOnRandomNumbers()
        {
            Random random = new Random();
            Console.WriteLine("Enter total number");
            int totalNumbers = int.Parse(Console.ReadLine());
            double average = 0;
            for (int i = 0; i < totalNumbers; i++)
            {
                double temp= random.Next(10, 50);
                Console.WriteLine(temp+" random number generated");
                average += temp;
            }
            Console.WriteLine($" average of above {totalNumbers} number is { average / totalNumbers}");
        }

        public static void FindMultipleOf7Not5()
        {

            for(int i = 2002; i <= 3200; i += 7)
            {
                if(i%7==0 && i%5!=0)
                {
                    Console.Write(i+",");
                }
            }
            Console.ReadLine();

        }


    }
}
