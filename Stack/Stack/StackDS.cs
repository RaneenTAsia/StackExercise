using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackDS<T>
    {
        Node<T> head;
        public StackDS()
        {

        }
        public void push(T item)
        {
            Node<T> node = new Node<T>(item);
            node.Next = head;
            head = node;

        }
        public Node<T> pop()
        {
            Node<T> del = head;
            head = head.Next;
            return del;
        }
        public void print()
        {
            Node<T> curr = head;
            while (curr != null)
            {
                Console.Write(curr.ToString());
                curr = curr.Next;
            }
            Console.WriteLine();
        }
        public void peak()
        {
            if (head != null)
            {
                Console.WriteLine(head.ToString());
            }

        }
        public void clear()
        {
            head = null;
        }
    }
}