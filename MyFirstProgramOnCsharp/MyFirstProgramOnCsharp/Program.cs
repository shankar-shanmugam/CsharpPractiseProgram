using System;

namespace MyFirstProgramOnCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("ENTER A NUMBER");
            // int number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Hello World!");
            //FindPositiveOrNegative(-6);
            //PrintNumbersFrom1ToN(40);
            // FindSumOfDigitOfNumber(495);
            //  Console.WriteLine(ReverseNumber(number));
            //  Console.WriteLine(FindFactorialNumber(number));

            //DisplayNames d= new DisplayNames();
            // 1)  d.PrintNames();

            // 2)  ProblemOnNumbers.SumAndDiffOfSquareOfTwoNumbers();
            // 3)  StringOperation.UpperAndLower();

            // 4) StringOperation.PrintNumberAsString();

            //  Console.WriteLine(args.Length);
            // 5)  StringOperation.CountNamePartsAndDisplay(args);

            // 6)  ProblemOnNumbers.AverageOnRandomNumbers();

            // 7)  Circle.AreaAndPerimeter();

          // 10)  ProblemOnNumbers.FindMultipleOf7Not5();

          // 9)  ExecutionTime.FindExecutionTimeOfProgram();

          // 10)  FindDate.FindNextDate();
        }

        static void FindPositiveOrNegative(int number)
        {

            if (number > 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("number is negative");
            }


            Console.ReadLine();
        }

        static void PrintNumbersFrom1ToN(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i + " ");
            }
        }

        static void FindSumOfDigitOfNumber(int number)
        {
            int sum = 0;
            do
            {
                sum += number % 10;
                number /= 10;
            } while (number > 0);
            Console.WriteLine(" sum of the number is " + sum);
        }

        static int ReverseNumber(int number)
        {
            int reverse = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }
            return reverse;
        }

        static int FindFactorialNumber(int number)
        {
            int factorial = 1;
            while (number >= 2)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }



    }
    class Calculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the number :");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number :");
            int num2 = int.Parse(Console.ReadLine());

            Calculator calculator = new Calculator();
            calculator.Add(num1, num2);


        }
        //1.add
        int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        int Substract(int num1, int num2)
        {
            return (num1 - num2);
        }

        int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        int Modulo(int num1, int num2)
        {
            return num1 % num2;
        }


    }
}
