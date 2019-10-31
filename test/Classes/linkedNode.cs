using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection
{
    public class LinkedNode<T>
    {
        private LinkedNode<T> _next; // نباید بصورت عمومی باشد خیلی خطرناک است چون قایل مقدار دهی است
        private T _data;
        public LinkedNode(T data) => _data = data;

        public T GetData() => _data;

        internal LinkedNode<T> GetNext() => _next;
        internal void SetNext(LinkedNode<T> currentItem, LinkedNode<T> newItem) => currentItem._next = newItem;
    }
}
