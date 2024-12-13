using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DataStructureDemo
{
    internal class LinkedListImpl
    {

        private Node head;
        private class Node
        {
            public Node next;
            public Object data;
            public Node(Object data)
            {
                this.data = data;
                next = null;
            }
        }
        public void Add(Object data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine($"\n{node.data} added successfully");
                return;
            }
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
            Console.WriteLine($"\n{node.data} added successfully");

        }

        public void AddFirst(Object data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine($"\n{node.data} added successfully");
                return;
            }
            node.next = head;
            head = node;
            Console.WriteLine($"\n{node.data} added successfully");
        }

        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("No elements present in the list ");
            }
            head = head.next;
            Console.WriteLine("\nsuccessfully removed first element in list");
        }

        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("No elements in the list");
                return;
            }
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.next != null)
                {
                    Console.Write("=>");
                }
                temp = temp.next;
            }
        }

        public void ReverseList()
        {
            if (head == null)
            {
                Console.WriteLine("No elements in the list");
                return;
            }
            
            Node current = head;
            Node prev = null;
            while (current != null)
            {
                Node temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

    }
}
