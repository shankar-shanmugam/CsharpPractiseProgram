using System;

namespace DataStructureDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //LinkedListImpl list=new LinkedListImpl();
            //list.Add(1);
            //list.Add(2);
            //list.Add(3);

            //list.Display();

            //list.DeleteFirst();
            //list.Display();

            //list.AddFirst(1);
            //list.ReverseList();
            //list.Display();

            SimpleList<int> list= new SimpleList<int>();
            list.Add(1);
            Console.WriteLine(list.Count+" count ");
            list.Add(2);
            Console.WriteLine(list.Get(1));
            




            
        }
    }
}
