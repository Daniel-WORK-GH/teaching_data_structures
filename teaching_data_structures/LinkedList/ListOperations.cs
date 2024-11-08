
namespace DataStructure.LinkedList;

public static class ListOperations
{
    public static void AddToTail<T>(Node<T>? head, T newvalue)
    {
        if (head == null) throw new ArgumentNullException("Head can't be null value.");

        while (head!.HasNext())
        {
            head = head.GetNext();
        }

        head.SetNext(new Node<T>(newvalue));
    }

    public static string ToString<T>(Node<T>? head)
    {
        string result = "";

        while (head != null)
        {
            result += head.ToString() + ", ";
            head = head.GetNext();
        }

        return result;
    }

    public static int GetLength<T>(Node<T>? head)
    {
        int len = 0;

        while (head != null)
        {
            len++;
            head = head.GetNext();
        }

        return len;
    }

    public static bool Contains<T>(Node<T>? head, T value)
    {
        while (head != null)
        {
            if (head.GetValue()!.Equals(value))
            {
                return true;
            }

            head = head.GetNext();
        }

        return false;
    }

    public static int GetMax(Node<int>? head)
    {
        int max = int.MinValue;
        while (head != null)
        {
            if (head.GetValue() > max)
            {
                max = head.GetValue();
            }
            head = head.GetNext();
        }
        return max;
    }

    public static void Insert<T>(Node<T>? head, T value, int index)
    {
        for (; index > 1; index--)
        {
            head = head.GetNext();
        }
        var temp = new Node<T>(value);
        temp.SetNext(head.GetNext());
        head.SetNext(temp);
    }
}