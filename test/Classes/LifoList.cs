using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Classes
{
    public abstract class LifoList<T>
    {

        private LinkedNode<T> last;
        public LifoList() => last = null;
        public void Add(T data)
        {
            var node = new LinkedNode<T>(data);
            if (last == null)
                last = node;
            else
            {
                node.SetNext(node, last);
                last = node;
            }
        }
        public LinkedNode<T> Remove()
        {
            if (last == null)
                throw new Exception("the stack is empty");

            LinkedNode<T> node = new LinkedNode<T>(last.GetData());
            var lastNext = last.GetNext();
            last = lastNext;
            return node;
        }

        public LinkedNode<T> Peek()
        {
            if (last == null)
                throw new Exception("the stack is empty");
            return last;
        }

        public void ClearAll() => last = null;

        public int CountOfStack()
        {
            LinkedNode<T> cursor = last;
            var counter = 0;
            while (cursor != null)
            {
                var cursorNext = cursor.GetNext();
                cursor = cursorNext;
                counter++;
            }
            return counter;
        }

        public bool IsEmpty() => last == null ? true : false;

        public List<T> GetAll()
        {
            var allItem = new List<T>();
            LinkedNode<T> cursor = last;
            while (cursor != null)
            {
                allItem.Add(cursor.GetData());
                var cursorNext = cursor.GetNext();
                cursor = cursorNext;
            }
            return allItem;
        }
    }
}
