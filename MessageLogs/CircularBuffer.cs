using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageLogs
{
    internal class CircularBuffer
    {
        private int size;
        private object[] buffer;
        private int head;
        private int tail;

        public CircularBuffer(int s)
        {
            size = s;
            buffer = new object[size];
        }

        public void Add(object item)
        {
            buffer[tail] = item;
            tail = (tail + 1) % size;

            if (tail == head)
            {
                head = (head + 1) % size;
            }
        }

        public object Pop()
        {
            object result = buffer[head];
            head = (head + 1) % size;
            return result;
        }
    }
}
