using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack<T>
    {
        Node<T> head;

        public Stack()
        {
        }

        public Status Push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = head;
            head = node;
            if (!head.Data.Equals(node.Data))
            {
                return Status.Failure;
            }
            return Status.Success;
        }

        public T Pop()
        {
            Node<T> del = head;
            head = head.Next;
            return del.Data;
        }

        public void Print()
        {
            IEnumerable<T> nodes = new List<T>();
            Node<T> curr = head;
            while (curr != null)
            {
                Console.Write(curr.ToString());
                curr = curr.Next;
            }
            Console.WriteLine();
        }

        public T Peak()
        {
            return head.Data;
        }

        public Status Clear()
        {
            head = null;
            if (head == null)
                return Status.Success;
            return Status.Failure;
        }
    }
}