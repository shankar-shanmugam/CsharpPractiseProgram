using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class DisplayNames
    {

        public void PrintNames()
        {
            Console.WriteLine("Enter the total no of friends :");
            int TotalNoOfNames = int.Parse(Console.ReadLine());
            String[] names = new String[TotalNoOfNames];

            for (int i = 0; i < TotalNoOfNames; i++)
            {
                int j = i + 1;
                Console.WriteLine("Enter the " + j + " name");
                names[i] = Console.ReadLine();
            }

            foreach (String name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

    }
}
