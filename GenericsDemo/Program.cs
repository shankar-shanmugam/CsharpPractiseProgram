using System;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            GenericWithoutDemo demo = new GenericWithoutDemo();
            //   Console.WriteLine("Greater number is "+demo.FindMaxInInteger());

            //  Console.WriteLine("Greater number is "+demo.FindMaxIndouble());

            //   Console.WriteLine("Greater number is "+demo.FindMaxString());

            GenericWithDemo<int> a = new GenericWithDemo<int>(1, 4, 5);
            a.Display();
            new GenericWithDemo<double>(22.4, 67.6, 89.2).Display();
            new GenericWithDemo<String>("abc","bcs","dfguyg").Display();


        }
    }
}
