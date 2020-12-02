using System;
using DataStructures.Libraries;

namespace DataStructures.LinkedListLibrary
{
    class LinkedListProgram
    {
        static void Main(string[] args)
        {
            var data = new int[] { 4, 5, 6, 1, 2, 3, 4, 8, 5, 4, 2, 6, 8, 9, 5, 3, 12, 6, 4, 3, 2, 4, 6, 7, 8, 8, 4, 3, 2, 1, 5, 6, 78, 7, 5, 3, 22, 211 };

            var linkedList = new LinkedList(data);

            var first = linkedList.GetFirst();
            var last = linkedList.GetLast();

            object[] full = linkedList.GetAll();

            Console.WriteLine("First: \t\t" + first);
            Console.WriteLine("Last: \t\t" + last);

            Console.Write("Full: \t\t");

            for(int i = 0; i < full.Length; i++)
            {
                Console.Write(full[i] + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
