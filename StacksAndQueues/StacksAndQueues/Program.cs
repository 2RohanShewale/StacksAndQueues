using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            while (true)
            {
                Console.WriteLine("Options: \n1.Stack Push\n2.Stack Pop\n");
                Console.Write("Enter a choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        break;

                    case 2:
                        stack.Pop();
                        break;
                    default:
                        stack.Display();
                        break;
                    
                }

            }

            
            stack.Pop();
            Console.ReadKey();
        }
    }
}
