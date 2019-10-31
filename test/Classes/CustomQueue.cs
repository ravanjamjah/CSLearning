using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Classes
{
    public class CustomQueue<T> : FifoList<T>
    {
        public void EnQueue(T data) => this.Add(data);

        public LinkedNode<T> DeQueue() => this.Remove();

        public void Clear() => this.ClearList();

        public int Count() => this.CountOfList();
    }
}
