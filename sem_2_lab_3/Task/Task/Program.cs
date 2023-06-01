using System;
using System.Collections;
using System.Collections.Generic;


public class Program
{
    public static void Main(string[] args)
    {

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
        
    }
    public void AddLast(Item item)
    {
        
    }
    public Item RemoveFirst()
    {
        return;
    }
    public Item RemoveLast()
    {
        return;
    }
    public IEnumerator<Item> GetEnumerator()
    {
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

    }
    public Item Dequeue()
    {

    }
    public Item Sample()
    {

    }
    public IEnumerator<Item> GetEnumerator()
    {

    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    private void Resize(int capacity)
    {

    }
    private void Shuffle(Item[] array)
    {

    }
}