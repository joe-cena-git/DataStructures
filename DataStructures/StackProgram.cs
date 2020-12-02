using DataStructures.Libraries;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class StackProgram
    {
        public static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(5);
            stack.Push(3);
            stack.Push(8);
            
            var result = stack.Pop();
        }
    }
}
