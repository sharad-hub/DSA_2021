using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2021.Basic
{

    public class Node
    {
        Node Next = null;
        int Data;


        public Node(int data)
        {
            Data = data;
        }

        public void AppendToTail(Node head, int data)
        {
            Node end = new Node(data);
            Node n = head;
            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = end;
        }

        public Node DeleteNode(Node head, int d)
        {
            Node n = head;

            if (n.Data == d)
            {
                return head.Next;
            }

            while (n.Next != null)
            {
                if(n.Data==d)
                {
                    n.Next=n.Next.Next;
                    return head;
                }
            }

            return head;
        }
    }
    public class LinkedListOperations
    {

    }
}
