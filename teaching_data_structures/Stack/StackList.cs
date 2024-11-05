using System.ComponentModel.DataAnnotations;
using DataStructure.LinkedList;

class StackList<T>
{
    Node<T>? lastnode;

    public StackList()
    {

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
    }

    public T Pop()
    {
        T result = lastnode.GetValue();
        lastnode = lastnode.GetNext();
        return result;
    }

    public T Peek()
    {
        T result = lastnode.GetValue();
        return result;
    }
}