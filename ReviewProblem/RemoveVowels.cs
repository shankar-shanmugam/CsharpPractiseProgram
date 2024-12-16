using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProblem
{
    internal class RemoveVowels
    {

        public static void Remove(String str)
        {
            char[] characters = str.ToCharArray();
            string result = "";

            foreach (char ch in characters)
            {
                if (ch != 'a' && ch != 'e' && ch != 'i' && ch != 'o' && ch != 'u' &&
                    ch != 'A' && ch != 'E' && ch != 'I' && ch != 'O' && ch != 'U')
                {
                    result += ch;
                }
            }

            Console.WriteLine("Result of string is "+result);

        }
    }
}
