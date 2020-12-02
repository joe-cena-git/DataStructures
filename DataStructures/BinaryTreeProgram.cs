﻿using DataStructures.Libraries;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BinaryTreeProgram
    {
        public static void Main(string[] args)
        {
            var binaryTree = new BinaryTree(1);

            binaryTree.AddValue(2);
            binaryTree.AddValue(3);
            binaryTree.AddValue(4);
            binaryTree.AddValue(5);

            Console.Write(binaryTree);

            Console.ReadKey();
        }
    }
}