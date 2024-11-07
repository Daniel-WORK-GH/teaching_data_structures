using DataStructure.LinkedList;

class QueueList<T>
{
    Node<T>? first;
    Node<T>? last;

    int size;

    public QueueList()
    {
        size = 0;
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
            last!.SetNext(node);
            last = node;
        }
        size++;
    }

    public T Dequeue()
    {
        if(first == null) 
        {
            throw new Exception("Can't dequeue - the queue is empty.");
        }

        T result = first.GetValue();
        first = first.GetNext();
        size--;
        return result;
    }

    public T Peek()
    {
        if(first == null) 
        {
            throw new Exception("Can't peek - the queue is empty.");
        }

        T result = first.GetValue();
        return result;
    }

    public int GetSize()
    {
        return size;
    }

    public bool IsEmpty() 
    {
        return size == 0;
    }

    public bool Contains(T value) 
    {
        Node<T>? temp = first;

        while(temp != null)
        {
            T? tempvalue = temp.GetValue(); 
            
            if((tempvalue != null && tempvalue.Equals(value)) || (tempvalue == null && value == null))
            {
                return true;
            }

            temp = temp.GetNext();
        }

        return false;
    }

    public QueueList<T> Reverse() 
    {
        throw new NotImplementedException("Not implemented yet.");
    }
}