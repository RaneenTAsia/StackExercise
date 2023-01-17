using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Node<T>
    {
        public Node()
        {

        }
        public Node(T data, Node<T> next)
        {
            Data = data;
            Next = next;
        }
        public Node(T data)
        {
            Data = data;
        }


        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public override string ToString()
        {
            if (Data != null)
            {
                return Data + "-> ";
            }
            else
                return null;
        }
    }
}