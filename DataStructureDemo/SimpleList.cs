using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureDemo
{
    internal class SimpleList<T>
    {
        private T[] items;
        private int size;

        public SimpleList()
        {
            items = new T[4]; // Initial capacity
            size = 0;
        }

        public void Add(T item)
        {
            if (size == items.Length)
            {
                T[] newItems = new T[items.Length * 2]; // Resize array
                Array.Copy(items, newItems, size);
                items = newItems;
            }

            items[size++] = item;
        }

        public T Get(int index)
        {
            if (index >= 0 && index < size)
            {
                return items[index];
            }
            throw new IndexOutOfRangeException();
        }

        public int Count { get { return size; } }
    }
}
