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

    }
}