using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsLab4
{
    class Queue<T>:IEnumerable<T>
    {
        Node<T> head;
        Node<T> tail;
        int count;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> tempNode = tail;
            tail = node;
            if (count == 0)
                head = tail;
            else
                tempNode.Next = tail;
            count++;
        }
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = head.Data;
            head = head.Next;
            count--;
            return output;
        }
        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public void Reverse()
        {
            Stack<T> temp = new Stack<T>();
            foreach (var item in this)
            {
                temp.Push(item);
                this.Dequeue();
            }
            while (temp.Count > 0)
            {
                this.Enqueue(temp.Peek());
                temp.Pop();
            }
        }
        public void Change()
        {
            Stack<T> temp = new Stack<T>();
            foreach (var item in this)
            {
                temp.Push(item);
                this.Dequeue();
            }
            temp.ChangePlaces();
            while (temp.Count > 0)
            {
                this.Enqueue(temp.Peak());
                temp.Pop();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

    }
}
