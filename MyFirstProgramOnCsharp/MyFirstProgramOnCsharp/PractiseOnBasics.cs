
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgramOnCsharp
{
    internal class PractiseOnBasics
    {
        void PractiseOnRandomClass()
        {
            Random r = new Random();
            int n = 10;
            int employeeID = r.Next(1, 10);
            Boolean b = false;
            for (int i = 0; i < n; i++)
            {
                if (i == employeeID)
                {
                    b = true;
                }
            }
            if (b)
            {
                Console.WriteLine("employee present");
            }
            else
            {
                Console.WriteLine("employee absent");
            }
            Console.ReadLine();
        }

    }
}
