using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stacks= new Stack();
            stacks.Push(10);
            stacks.Push(20);
            stacks.Push(30);
            stacks.Display();
            Console.ReadKey();
        }
    }
}
