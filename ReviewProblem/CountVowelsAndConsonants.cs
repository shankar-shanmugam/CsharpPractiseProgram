using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProblem
{
    internal class CountVowelsAndConsonants
    {
        public static void CountVowelsAndConsonantsInString(string str)
        {
           str= str.ToLower();
          char[] ch=  str.ToCharArray();
            int vowelsCount = 0;
            int consonantsCount = 0;

          for (int i= 0; i < ch.Length; i++)
            {
                if (ch[i] >= 'a' && ch[i] <= 'z')
                {
                    if (ch[i]=='a' || ch[i]=='e' || ch[i]=='i' || ch[i]=='u' || ch[i]=='o') vowelsCount++;
                    else consonantsCount++;
                }
            }

            Console.WriteLine($"total vowels and consonants present in {str} is \n vowel : {vowelsCount} \n consonant : {consonantsCount}");


        }


    }
}
