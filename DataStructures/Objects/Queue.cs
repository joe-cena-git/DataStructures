using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Objects
{
    public class Queue
    {
        private QueueNode _First;
        private QueueNode _Last;

        public Queue()
        {
            
        }

        public void Push(int value)
        {
            var newNode = new QueueNode(value);
            if(_First == null && _Last == null)
            {
                _First = newNode;
                _Last = newNode;
            }
            else
            {
                _First.SetPrev(newNode);
                newNode.SetNext(_First);
                _First = newNode;
            }
        }

        public int Peek()
        {
            return _Last.GetValue();
        }

        public int Pop()
        {
            var oldLast = _Last;
            _Last = _Last.GetPrev();
            _Last.SetNext(null);
            return oldLast.GetValue();
        }

        internal class QueueNode
        {
            private int _Data;
            private QueueNode _Next;
            private QueueNode _Prev;

            public QueueNode(int value)
            {
                _Data = value;
            }

            public int GetValue()
            {
                return _Data;
            }

            public void SetNext(QueueNode nextNode)
            {
                _Next = nextNode;
            }

            public QueueNode GetNext()
            {
                return _Next;
            }

            public void SetPrev(QueueNode prevNode)
            {
                _Prev = prevNode;
            }

            public QueueNode GetPrev()
            {
                return _Prev;
            }
        }
    }
}
