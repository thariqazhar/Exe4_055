using System;

namespace Exception
{
    class Stack
    {
        int[] azhar = new int[73];
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

    class Program
    {
        static void Main()
        {
            Stack s = new Stack(73);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push.");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice: ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);

                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack is empty. There's nothing to pop");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.printStack();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}