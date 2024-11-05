using DataStructure.LinkedList;

class QueueList<T>
{
    Node<T> first;
    Node<T> last;

    public QueueList()
    {

    }

    public void Enqueue(T value)
    {
        if (first == null)
        {
            last = new Node<T>(value);
            first = last;
        }
        else
        {
            Node<T> node = new Node<T>(value);
            last.SetNext(node);
            last = node;
        }
    }

    public T Dequeue()
    {
        T result = first.GetValue();
        first = first.GetNext();
        return result;
    }

    public T Peek()
    {
        T result = first.GetValue();
        return result;
    }
}