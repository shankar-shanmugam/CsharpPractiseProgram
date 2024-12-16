using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProblem
{
    internal class DateProblem
    {
        public static void FindAddDate()
        {
            Console.Write("Enter a date : ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the number of days to add: ");
            int daysToAdd = int.Parse(Console.ReadLine());



            DateTime newDate = date.AddDays(daysToAdd);

            Console.WriteLine($"The new date after adding {daysToAdd} days is: {newDate}");
        }

        public static void FindDifferenceInDate()
        {
            Console.Write("Enter the first date  ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the second date ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan difference = secondDate - firstDate;

            Console.WriteLine($"The difference between the two dates is: {difference.Days} days");
        }


    }
}
