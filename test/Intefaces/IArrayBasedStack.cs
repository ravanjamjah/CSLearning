using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection.Intefaces
{
    public interface IArrayBasedStack<T>
    {
        int Capacity();
        void GrowArray();
        void Push(T val);
        T Pop();
        bool IsFull();
    }
}
