using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Classes
{
    public class CustomStack<T> : LifoList<T>
    {
        public void PrintAll()
        {
            var allItem = GetAll();
            foreach (var item in allItem)
                Console.WriteLine(item);
        }
        public LinkedNode<T> PeekFromStack() => Peek();

        public LinkedNode<T> Pop() => Remove();

        public T PopData() => this.Remove().GetData();

        public void Push(T input) => Add(input);

        public int Count() => CountOfStack();

        internal void Clear() => ClearAll();
    }
}
