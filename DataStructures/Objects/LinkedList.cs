using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Objects
{
    public class LinkedList
    {
        private LinkedListNode _Head = null;

        public LinkedList(object[] data)
        {
            for(int i = 0; i < data.Length - 1; i++)
            {
                AddToEnd(data[i]);
            }
        }

        public LinkedList(int[] data)
        {
            foreach (int i in data)
            {
                AddToEnd(i);
            }
        }

        public object GetFirst()
        {
            return _Head.GetData();
        }

        public void AddToEnd(object data)
        {
            var newNode = new LinkedListNode(data);

            if(_Head == null)
            {
                _Head = newNode;
            }
            else
            {
                LinkedListNode selectedNode = _Head;

                while (selectedNode.HasNext())
                {
                    selectedNode = selectedNode.GetNext();
                }

                selectedNode.SetNextNode(newNode);
            }
        }

        public void InsertAtFront(object data)
        {
            var newHead = new LinkedListNode(data);
            newHead.SetNextNode(_Head);
            _Head = newHead;
        }

        public object[] GetAll()
        {
            if(_Head == null)
            {
                return null;
            }
            else
            {
                var currentSize = this.GetSize();

                var objects = new object[currentSize];

                LinkedListNode selectedNode = _Head;

                for (int i = 0; i < currentSize; i++)
                {
                    objects[i] = selectedNode.GetData();
                    if (selectedNode.HasNext())
                    {
                        selectedNode = selectedNode.GetNext();
                    }                    
                }
                
                return objects;
            }
        }

        public int GetSize()
        {
            if(_Head == null)
            {
                return 0;
            }
            else
            {
                int size = 1;
                LinkedListNode selectedNode = _Head;

                while (selectedNode.HasNext())
                {
                    size++;
                    selectedNode = selectedNode.GetNext();
                }

                return size;
            }
        }

        public object GetLast()
        {
            if(_Head == null)
            {
                return null;
            }
            else
            {
                LinkedListNode selectedNode = _Head;

                while (selectedNode.HasNext())
                {
                    selectedNode = selectedNode.GetNext();
                }

                return selectedNode.GetData();
            }
        }
    }

    internal class LinkedListNode
    {
        private object _Data = null;
        private LinkedListNode _Next = null;

        public LinkedListNode(object data)
        {
            _Data = data;
        }

        public void SetNextNode(LinkedListNode next)
        {
            _Next = next;
        }

        public object GetData()
        {
            return _Data;
        }

        public bool HasNext()
        {
            if (_Next == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public LinkedListNode GetNext()
        {
            return _Next;
        }
    }
}
