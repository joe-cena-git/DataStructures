using System;

namespace DataStructures.Objects
{
    // stores values in a sorted binary tree where all left nodes are less than or equal to parent
    public class BinaryTree
    {
        private BinaryTreeNode _Root;

        public BinaryTree(int firstValue)
        {
            _Root = new BinaryTreeNode(firstValue);
        }

        public void AddValue(int value)
        {
            var selectedNode = _Root;

            while (value <= selectedNode.GetValue() && selectedNode.HasLeftChild())
            {
                selectedNode = selectedNode.GetLeftChild();
            }

            while(value > selectedNode.GetValue() && selectedNode.HasRightChild())
            {
                selectedNode = selectedNode.GetRightChild();
            }

            if (value <= selectedNode.GetValue())
            {
                selectedNode.AddLeftChild(new BinaryTreeNode(value));
            }
            else
            {
                selectedNode.AddRightChild(new BinaryTreeNode(value));
            }
        }

        public int GetHeight()
        {
            return FindHeight(_Root);
        }

        private int FindHeight(BinaryTreeNode node)
        {
            if(node == null)
            {
                return 0;
            }
            else
            {
                return Math.Max(FindHeight(node.GetLeftChild()), FindHeight(node.GetRightChild())) + 1;
            }
        }

        public void PrintTree()
        {
            var height = GetHeight();
            for(int i = 1; i <= height; i++)
            {
                PrintGivenLevel(_Root, i);
            }
            
        }

        private void PrintGivenLevel(BinaryTreeNode node, int level)
        {
            if (node == null)
            {
                return;
            }
            else if(level == 1)
            {
                Console.Write(node.GetValue() + " ");
            }
            else if(level > 1)
            {
                PrintGivenLevel(node.GetLeftChild(), level - 1);
                PrintGivenLevel(node.GetRightChild(), level - 1);
            }
        }
    }

    internal class BinaryTreeNode
    {
        private int _Value;
        private BinaryTreeNode _Parent;
        private BinaryTreeNode _LeftChild;
        private BinaryTreeNode _RightChild;

        public BinaryTreeNode(int value)
        {
            _Value = value;
        }

        public int GetValue()
        {
            return _Value;
        }

        public bool HasRightChild()
        {
            if (_RightChild != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public BinaryTreeNode GetRightChild()
        {
            return _RightChild;
        }

        public bool HasLeftChild()
        {
            if (_LeftChild != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public BinaryTreeNode GetLeftChild()
        {
            return _LeftChild;
        }

        public BinaryTreeNode GetParent()
        {
            return _Parent;
        }

        public void AddLeftChild(BinaryTreeNode childNode)
        {
            _LeftChild = childNode;
        }

        public void AddRightChild(BinaryTreeNode childNode)
        {
            _RightChild = childNode;
        }

        public override string ToString()
        {
            return _Value.ToString();
        }
    }
}
