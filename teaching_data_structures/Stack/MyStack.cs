public class MyStack<T> {
    private T[] items;

    private int lastItem;

    public MyStack(int size)
    {
        this.items = new T[size];
        this.lastItem = -1;
    }

    public void Push(T item)
    {
        lastItem++;
        items[lastItem] = item;
    }

    public T Pop()
    {
        var item = items[lastItem];
        lastItem--;
        return item;
    }

    public T Peek() 
    {
        return items[lastItem];
    }

    public bool IsEmpty() 
    {
        return lastItem == -1;
    }

    public bool IsFull() 
    {
        return lastItem == items.Length - 1;
    }

    public bool Contains(T value) {
        for(int i = 0; i <= lastItem; i++) 
        {
            if(items[i]!.Equals(value))
            {
                return true;
            }
        }
        return false;
    }

    public void SwapLast2()
    {
        T a = items[lastItem];
        T b = items[lastItem - 1];

        items[lastItem] = b;
        items[lastItem - 1] = a;
    }
}