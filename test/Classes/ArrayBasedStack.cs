using CustomCollection.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Classes
{
    public class ArrayBasedStack<T> : IArrayBasedStack<T>
    {
        T[] items; // private ya public ro behtare benvisid
					// chera Araye?! list behtar nist?
        int top;
        public int Capacity() => items?.Length ?? 0; // injori ham mishe nevesht   =>  items?.Length ?? 0

        public void GrowArray()
        {
            int capacity = Capacity();
            int newLength = capacity == 0 ? 2 : capacity * 2;
            T[] newarray = new T[newLength];  
            if(items != null)
                items.CopyTo(newarray, 0);
            items = newarray;
        }

        public T Pop()
        {
            if (top == 0)
            {
                throw new InvalidOperationException("Empty");
            }
            top--;
            return items[top];
        }

        public void Push(T val)
        {
            if (IsFull())
                GrowArray();
            items[top++] = val;
        }

        public bool IsFull()
        {
            return items == null ? true : (top == items.Length);
        }
    }
}
