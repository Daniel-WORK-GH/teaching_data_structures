using DataStructure.LinkedList;
using System;
using System.Numerics;

public class Program
{
    public static void Main(string[] args)
    {
        Node<int> head = new Node<int>(1);

        ListOperations.AddToTail(head, 3);
        ListOperations.AddToTail(head, 7);
        ListOperations.AddToTail(head, 2);

        string result = ListOperations.ToString(head);

        System.Console.WriteLine($"List = {result}");

        int length = ListOperations.GetLength(head);

        System.Console.WriteLine($"Length = {length}");

        bool contains7 = ListOperations.Contains(head, 7);
        bool contains10 = ListOperations.Contains(head, 10);

        System.Console.WriteLine($"Contains7 = {contains7}");
        System.Console.WriteLine($"contains10 = {contains10}");

        int max = ListOperations.GetMax(head);

        System.Console.WriteLine($"max = {max}");

        ListOperations.Insert(head, 100, 1);

        result = ListOperations.ToString(head);
        System.Console.WriteLine($"List = {result}");
    }
}