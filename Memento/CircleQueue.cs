using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class CircularQueue<T>
    {
        public Nod<T>[] root;
        int maxLength;
        int currentLength;
        public CircularQueue(int size)
        {
            root = new Nod<T>[size];
            maxLength = size;
            currentLength = 0;
        }
    }

    public class Nod<T>
    {
        public T data;
        internal Nod<T> next;
        internal Nod<T> previous;
        public Nod() { }
    }
}
