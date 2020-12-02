using DataStructures.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class QueueProgram
    {
        public static void Main(string[] args)
        {
            var q = new Queue();

            q.Push(1);
            q.Push(2);
            q.Push(3);
            q.Push(4);
            q.Push(5);

            Console.WriteLine(q.Peek());

            Console.WriteLine(q.Pop());
            Console.WriteLine(q.Pop());

            Console.ReadKey();
        }
    }
}
