using System;
using System.Collections.Generic;
using System.Text;

namespace ReviewProblem
{
    internal class GcdAndLcm
    {
        public static void FindGcd(int num1,int num2) // 60 30
        {
            int gcd = 1;
            int min = num1 < num2 ? num1 : num2;
            
            for(int i = min; i > 1;i--)
            {
                if(num1 % i == 0 && num2 % i == 0)
                {
                    gcd = i;
                    break;
                }
            }

            Console.WriteLine($"Gcd of {num1} and {num2} is {gcd} ");

        }

        public static void FindLcm(int num1,int num2) // 4 6 
        {
            int max=num1 > num2 ? num1 : num2;
            int lcm = max;
            while(true)
            {
                if(lcm % num1 == 0 && lcm % num2 == 0)
                {
                    break;
                }
                lcm += max;
            }

            Console.WriteLine($"Lcm of {num1} and {num2} is {lcm} ");
        }

    }
}
