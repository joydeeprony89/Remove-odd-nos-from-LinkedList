using System;

namespace Remove_odd_nos_from_LinkedList
{
    class Program
    {
        class Node
        {
            public int val { get; set; }
            public Node next { get; set; }
            public Node(int val = 0)
            {
                this.val = val;
                next = null;
            }
        }
        static void Main(string[] args)
        {
            Node head = new Node(4);
            head.next = new Node(1);
            head.next.next = new Node(2);
            head.next.next.next = new Node(2);
            head.next.next.next.next = new Node(1);
            head.next.next.next.next.next = new Node(0);

            RemoveOdd(head);
            Print(head);
        }

        static void Print(Node head)
        {
            while(head != null)
            {
                Console.WriteLine(head.val);
                head = head.next;
            }
        }

        static Node RemoveOdd(Node head)
        {
            Node temp = head;
            while (temp != null && temp.next != null)
            {
                if (temp.next.val % 2 != 0)
                    temp.next = temp.next.next;
                else temp = temp.next;
            }

            return head;
        }
    }
}
