using System;
using System.Collections;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {
        // Test Deque
        Deque<int> deque = new Deque<int>();

        deque.AddFirst(3);
        deque.AddFirst(2);
        deque.AddLast(4);
        deque.AddLast(5);

        Console.WriteLine("Deque size: " + deque.Size());

        foreach (int item in deque)
            Console.WriteLine("Item: " + item);

        int firstItem = deque.RemoveFirst();
        int lastItem = deque.RemoveLast();

        Console.WriteLine("Removed first item: " + firstItem);
        Console.WriteLine("Removed last item: " + lastItem);

        Console.WriteLine("Is Deque empty? " + deque.IsEmpty());

        // Test RandomizedQueue
        RandomizedQueue<string> randomizedQueue = new RandomizedQueue<string>();

        randomizedQueue.Enqueue("A");
        randomizedQueue.Enqueue("B");
        randomizedQueue.Enqueue("C");
        randomizedQueue.Enqueue("D");

        Console.WriteLine("RandomizedQueue size: " + randomizedQueue.Size());

        foreach (string item in randomizedQueue)
            Console.WriteLine("Item: " + item);

        string randomItem = randomizedQueue.Dequeue();

        Console.WriteLine("Removed random item: " + randomItem);

        Console.WriteLine("Is RandomizedQueue empty? " + randomizedQueue.IsEmpty());
    }
}
public class Deque<Item> : IEnumerable<Item>
{
    private Node first;
    private Node last;
    private int size;

    private class Node
    {
        public Item item;
        public Node next;
        public Node prev;
    }
    public Deque()
    {
        first = null;
        last = null;
        size = 0;
    }
    public bool IsEmpty()
    {
        return size == 0;
    }
    public int Size()
    {
        return size;
    }
    public void AddFirst(Item item)
    {
        if (item == null)
            throw new ArgumentNullException();

        Node newNode = new Node
        {
            item = item,
            next = first,
            prev = null
        };

        if (IsEmpty())
            last = newNode;
        else
            first.prev = newNode;

        first = newNode;
        size++;
    }
    public void AddLast(Item item)
    {
        if (item == null)
            throw new ArgumentNullException();

        Node newNode = new Node
        {
            item = item,
            next = null,
            prev = last
        };

        if (IsEmpty())
            first = newNode;
        else
            last.next = newNode;

        last = newNode;
        size++;
    }
    public Item RemoveFirst()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Deque is empty.");

        Item item = first.item;
        first = first.next;

        if (first == null)
            last = null;
        else
            first.prev = null;

        size--;
        return item;
    }
    public Item RemoveLast()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Deque is empty.");

        Item item = last.item;
        last = last.prev;

        if (last == null)
            first = null;
        else
            last.next = null;

        size--;
        return item;
    }

    public IEnumerator<Item> GetEnumerator()
    {
        Node current = first;
        while (current != null)
        {
            yield return current.item;
            current = current.next;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class RandomizedQueue<Item> : IEnumerable<Item>
{
    private Item[] items;
    private int size;

    public RandomizedQueue()
    {
        items = new Item[1];
        size = 0;
    }
    public bool IsEmpty()
    {
        return size == 0;
    }
    public int Size()
    {
        return size;
    }
    public void Enqueue(Item item)
    {
        if (item == null)
            throw new ArgumentNullException();

        if (size == items.Length)
            Resize(2 * items.Length);

        items[size++] = item;
    }
    public Item Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("RandomizedQueue is empty.");

        int randomIndex = new Random().Next(size);
        Item item = items[randomIndex];

        items[randomIndex] = items[size - 1];
        items[size - 1] = default(Item);
        size--;

        if (size > 0 && size == items.Length / 4)
            Resize(items.Length / 2);

        return item;
    }
    public Item Sample()
    {
        if (IsEmpty())
            throw new InvalidOperationException("RandomizedQueue is empty.");

        int randomIndex = new Random().Next(size);
        return items[randomIndex];
    }
    public IEnumerator<Item> GetEnumerator()
    {
        Item[] shuffled = new Item[size];
        Array.Copy(items, shuffled, size);
        Shuffle(shuffled);

        foreach (Item item in shuffled)
            yield return item;
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    private void Resize(int capacity)
    {
        Item[] newArray = new Item[capacity];
        Array.Copy(items, newArray, size);
        items = newArray;
    }
    private void Shuffle(Item[] array)
    {
        int n = array.Length;
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int r = i + random.Next(n - i);
            Item temp = array[r];
            array[r] = array[i];
            array[i] = temp;
        }
    }
}