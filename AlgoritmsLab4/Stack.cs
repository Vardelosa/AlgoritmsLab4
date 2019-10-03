using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLab4
{
    class Stack<T>

    {
        private T[] items;
        private int count;
        const int n = 10;
        public Stack()
        {
            items = new T[n];
        }
        public Stack(int length)
        {
            items = new T[length];
        }
        public bool IsEmpty
        {
            get { return count == 0; }
        }
        public int Count
        {
            get { return count; }
        }
        public void Push(T item)
        {
            if (count == items.Length)
                Resize(items.Length + 10);
            items[count++] = item;
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            T item = items[--count];
            items[count] = default(T);
            if (count > 0 && count < items.Length - 10)
                Resize(items.Length - 10);
            return item;
        }
        public T Peek()
        {
            return items[count - 1];
        }
        private void Resize(int max)
        {
            T[] temp = new T[max];
            for (int i = 0; i < count; i++)
                temp[i] = items[i];
            items = temp;
        }
        public void ChangePlaces()
        {
            T temp = default;
            temp = items[0];
            items[0] = items[count - 1];
            items[count - 1] = temp;
        }
    }
}
