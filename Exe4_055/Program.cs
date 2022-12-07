using System;

namespace Exception
{
    class Stack
    {
        int[] azhar = new int[3];
        private int top;
        private int max;

        public Stack(int size)
        {
            azhar = new int[size];
            top = -1;
            max = size;
        }
        public void push(int item)
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                azhar[++top] = item;
            }
        }
    }
}