namespace CustomCollection.Classes
{
    public abstract class FifoList<T>
    {
        private LinkedNode<T> first;

        private LinkedNode<T> GetFirst() => first;
        private LinkedNode<T> GetLast(LinkedNode<T> item)
        {
            var itemNext = item.GetNext();
            if (itemNext == null)
                return item;
            else
                return GetLast(itemNext);
        }

        private void SetFirst(LinkedNode<T> val) => first = val; //گذاشتن این تابع بصورت عمومی درست نیست چون عملکرد آن می تواند اطلاعات کلاس را خراب کند و یا باید کنترلی روی آن گذاشت

        public FifoList()
        {
            first = null;
        }
        public void Add(T data)
        {
            LinkedNode<T> item = new LinkedNode<T>(data);
            if (first == null)
                first = item;
            else
            {
                var lastItem = GetLast(first);
                lastItem.SetNext(lastItem, item);
            }
        }

        public LinkedNode<T> Remove()
        {
            LinkedNode<T> data;
            if (first == null)
                data = null;
            else
            {
                LinkedNode<T> old = first;
                var firstNext = first.GetNext();
                SetFirst(firstNext);
                data = old;
            }
            return data;
        }

        public void ClearList() => first = null;

        public int CountOfList()
        {
            LinkedNode<T> cursor = GetFirst();
            var counter = 0;
            while (cursor != null)
            {
                var cursorNext = cursor.GetNext();
                cursor = cursorNext;
                counter++;
            }
            return counter;
        }
    }
}
