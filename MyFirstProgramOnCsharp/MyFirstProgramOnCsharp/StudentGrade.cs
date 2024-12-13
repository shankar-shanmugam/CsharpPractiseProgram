using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class StudentGrade
    {

        public static void FindGrade()
        {

            Console.Write("Enter the Mark");
           int mark = int.Parse(Console.ReadLine());


            if(mark >= 90)
            {
                Console.WriteLine("Student grade is --> A");
            }
            else if(mark >= 80)
            {
                Console.WriteLine("student grade is --> B");
            }
            else if(mark >= 70)
            {
                Console.WriteLine("student grade is --> C");
            }
            else if (mark >=60)
            {
                Console.WriteLine("student grade is --> D");
            }
            else
            {
                Console.WriteLine("student grade is --> F");
            }
            Console.ReadLine();

        }

    }
}
