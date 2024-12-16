using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class GenericWithoutDemo
    {

        public  int FindMaxInInteger()
        {
            Console.Write("Enter the number 1: ");
          int num1= int.Parse( Console.ReadLine());

            Console.Write("Enter the number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            return num1 > num2 ?(num1 > num3? num1 : num3) : num2 > num3 ? num2 : num3;
        }

        public  double FindMaxIndouble()
        {

            Console.Write("Enter the number 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the number 2: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the number 3: ");
            double num3 = double.Parse(Console.ReadLine());

            return num1 > num2 ? (num1 > num3 ? num1 : num3) : num2 > num3 ? num2 : num3;

        }


        public  String FindMaxString()
        {
            Console.Write("Enter the string1 :");
           string s1= Console.ReadLine();

            Console.Write("Enter the string2 :");
          string s2=  Console.ReadLine();

            Console.Write("Enter the string3 :");
           string s3= Console.ReadLine();

            string max = s1;
            if(max.CompareTo(s2) < 0) max = s2;
            if(max.CompareTo(s3) < 0)max = s3;

            return max;

        }


    }
}
