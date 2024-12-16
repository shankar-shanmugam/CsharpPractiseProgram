using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    internal class GenericWithDemo<T>where T : IComparable<T>
    {
        private T number1;
        private T number2;
        private T number3;

        public GenericWithDemo(T num1,T num2,T num3)
        {
            this.number1 = num1; this.number2 = num2; this.number3 = num3;
        }

        public T FindMax()
        {
            T max = number1;

            if (number2.CompareTo(max) > 0)
                max = number2;

            if (number3.CompareTo(max) > 0)
                max = number3;

            return max;
        }

        public void Display()
        {
            Console.WriteLine(" max value of element is :" + FindMax());
        }

    }
}
