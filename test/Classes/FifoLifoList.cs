using static CustomCollection.Classes.MyProjectEnums;

namespace CustomCollection.Classes
{
    public class FifoLifoList<T>
    {
        LinkedNode<T> first;
        LinkedNode<T> last;
        CollectionNames collectionNames;

        public FifoLifoList(int collectionNames)
        {
            first = null;
            last = null;
            this.collectionNames = (CollectionNames)collectionNames;
        }
        public void Add(T data)
        {
            var item = new LinkedNode<T>(data);
            
            if(collectionNames == CollectionNames.Queue)
            {
                if (first == null)
                    last = first = item;
                else
                {
                    last.SetNext(last, item);
                    last = item;
                }
            }
            else if (collectionNames == CollectionNames.Stack)
            {
                if (last != null)
                    last.SetNext(last, item);
                else
                    first = item;
                last = item;
            }
        }

        public LinkedNode<T> Remove()
        {
            var firstNext = first.GetNext();
            var lastNext = first.GetNext();
            if (collectionNames == CollectionNames.Queue)
            {
                LinkedNode<T> data;
                if (first == null)
                    data = null;
                else
                {
                    LinkedNode<T> old = first;
                    first = firstNext;
                    data = old;
                }
                return data;
            }
            else if (collectionNames == CollectionNames.Stack)
            {
                if (last == null)
                    return last;

                LinkedNode<T> node = new LinkedNode<T>(last.GetData());
                last = lastNext;
                return node;
            }
            return null;
        }
    }
}
