using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    internal class Node
    {
        public int data;
        public Node next;
        public Node(int data) 
        {
            this.data = data;
        }
    }
}
