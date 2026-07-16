using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Build_Stack.StackFile
{
    public class SimpleStack
    {
        private string[] items = new string[10];
        private int count = 0;
        public void Push(string input)
        {
            count++;
            items[items.Length - count] = input;
        }
        public string Pop()
        {
            if (!IsEmpty())
            {
                int difference = items.Length - count;
                string itemRemoved = items[difference];
                items[difference] = null;
                count--;
                return itemRemoved;
            }
            else
                return "No items in stack";
        }
        public void Peek()
        {
            int difference = items.Length - count;
            string itemRemoved = items[difference];
            Console.WriteLine(itemRemoved);
        }
        public bool IsEmpty()
        {
            bool empty = true;
            if (count == 0)
            {
                return empty;
            }
            else
                return !empty;
        }
        public void PrintStack()
        {
            foreach(string input in items.Reverse())
            {
                if(input != null)
                    Console.WriteLine(input);
            }
        }
    }
}
