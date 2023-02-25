using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace StacksAndQueues
{
    internal class Stack
    {
        public Node top;
        public Stack() 
        {
            top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
                node.next = null;
            else
                node.next = top;
            top = node;
            Console.WriteLine($"{data} Has been added");
        }
        public void Display()
        {
            Node temp = top;
            Console.WriteLine("The Stack: \n");
            while (temp != null)
            {
                Console.WriteLine($"|{temp.data}|");
                Console.WriteLine("---");
                temp = temp.next;
            }
        }
    }
}
