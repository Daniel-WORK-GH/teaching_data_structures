using DataStructure.LinkedList;

class StackList<T>
{
    Node<T>? lastnode;

    int size;

    public StackList()
    {
        size = 0;
    }

    public void Push(T value)
    {
        if (lastnode == null)
        {
            lastnode = new Node<T>(value);
        }
        else
        {
            Node<T> node = new Node<T>(value);
            node.SetNext(lastnode);
            lastnode = node;
        }
        size++;
    }

    public T Pop()
    {
        if(lastnode == null) 
        {
            throw new Exception("Can't pop - the stack is empty.");
        }

        T result = lastnode.GetValue();
        lastnode = lastnode.GetNext();
        size--;
        return result;
    }

    public T Peek()
    {
        if(lastnode == null) 
        {
            throw new Exception("Can't peek - the stack is empty.");
        }

        T result = lastnode.GetValue();
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
        Node<T>? temp = lastnode;

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

    public StackList<T> Reverse() 
    {
        StackList<T> result = new StackList<T>();
        Node<T>? temp = lastnode;

        while(temp != null)
        {
            T? tempvalue = temp.GetValue(); 
            result.Push(tempvalue);
            temp = temp.GetNext();
        }

        return result;
    }
}