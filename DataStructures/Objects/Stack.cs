using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Objects
{
    public class Stack
    {
        private StackNode _Top;

        public bool IsEmpty()
        {
            return _Top == null;
        }

        public int Pop()
        {
            return _Top.GetData();
        }

        public void Push(int value)
        {
            var newNode = new StackNode(value);

            if(_Top == null)
            {
                _Top = newNode;
            }
            else
            {
                newNode.SetNext(_Top);
                _Top = newNode;
            }
        }

        internal class StackNode
        {
            private int _Data;
            private StackNode _Next;

            public StackNode(int value)
            {
                _Data = value;
            }

            public void SetNext(StackNode nextNode)
            {
                _Next = nextNode;
            }

            public StackNode GetNext()
            {
                return _Next;
            }

            public int GetData()
            {
                return _Data;
            }
        }
    }
}
