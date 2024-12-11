using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class FindDate
    {

        public static void FindNextDate()
        {

            Console.WriteLine("enter the year :");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the month(1-12) :");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the day(1-31) :");
            int day = int.Parse(Console.ReadLine());

            DateTime t = new DateTime(year,month,day);
            Console.WriteLine($" next date is {t.AddDays(1)}");

        }


    }
}
