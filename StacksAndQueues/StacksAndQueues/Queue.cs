using System;

namespace StacksAndQueues
{
    public class Queue
    {
        private Node front;
        private Node tail;

        public Queue()
        {
            this.front = null;
            this.tail = null;
        }
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (tail == null)
            {
                tail = node;
                front = node;
            }
            else
            {
                node.next = tail;
                tail = node;
            }
            Console.WriteLine($"\n{data} is added in queue");
        }
        public void Dequeue()
        {
            if (tail != null)
            {
                if (tail.next == null)
                {
                    tail = null;
                }
                else
                {
                    Node temp = tail;
                    while (temp.next.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = null;
                    front = temp;
                }
            }
            
            Display();
        }
        public void Display()
        {
            if (tail != null)
            {
                Node temp = tail;
                Console.WriteLine("\nThe Queue: ");
                while (temp != null)
                {
                    Console.Write($"|{temp.data}|");
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
            Console.WriteLine();
        }


    }
}
