using DataStructure.LinkedList;

class SortedIntList
{
    Node<int>? head;

    public SortedIntList()
    {
        head = null;
    }

    public void Add(int value)
    {
        if (head == null) // List is empty
        {
            head = new Node<int>(value);
        }
        else
        {
            Node<int>? temp = head;

            while (temp != null)
            {
                if (temp.GetNext() == null) // End of nod
                {
                    Node<int> valuenode = new Node<int>(value);
                    temp.SetNext(valuenode);
                    break;
                }
                else if (temp.GetValue() < value && value <= temp.GetNext()!.GetValue()) // Insert into list
                {
                    Node<int> valuenode = new Node<int>(value);
                    valuenode.SetNext(temp.GetNext()!);
                    temp.SetNext(valuenode);
                    break;
                }
                temp = temp.GetNext();
            }
        }
    }

    public bool Contains(int value)
    {
        Node<int>? temp = head;

        while (temp != null)
        {
            if(temp.GetValue() == value) 
            {
                return true;
            }

            temp = temp.GetNext();
        }

        return false;
    }
} 