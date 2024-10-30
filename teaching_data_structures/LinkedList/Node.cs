using System.Reflection;

namespace DataStructure.LinkedList;

public class Node<T> // <T> = generic
{
    private T value; // The value of the current cell

    private Node<T>? next; // Pointer to the next cell

    public Node(T value)
    {
        this.value = value;
        next = null;
    }

    public Node(T value, Node<T> next)
    {
        this.value = value;
        this.next = next;
    }

    public T GetValue()
    {
        return this.value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }

    public Node<T>? GetNext()
    {
        return this.next;
    }

    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    public bool HasNext()
    {
        return next != null;
    }

    public override string ToString()
    {
        return value!.ToString()!;
    }
}