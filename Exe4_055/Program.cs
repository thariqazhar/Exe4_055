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
        public int pop()
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                Console.WriteLine("Popped element is: " + azhar[top]);
                return azhar[top--];
            }
        }
        public bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);
        }
        public void printStack()
        {
            if (empty())
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + azhar[i]);
                }
            }
        }
    }
}