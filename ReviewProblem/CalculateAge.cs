using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProblem
{
    internal class CalculateAge
    {
        public static void CalculateAgeByDate()
        {
            Console.Write("Enter a date : ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

          DateTime currentDate =  DateTime.Now;
            int age=currentDate.Year - birthday.Year;

            Console.WriteLine("Age of person is "+age);

        }
    }
}
