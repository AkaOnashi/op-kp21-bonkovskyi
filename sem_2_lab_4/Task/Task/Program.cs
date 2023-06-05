using System;
public class Program
{
    public static void Main(string[] args)
    {
        HashTable<string, bool> dictionary = new HashTable<string, bool>();

        string text = "apple all and boy book call car chair children city dog door enemy end enough eat friend father go good girl food hear house inside laugh listen man name never next new noise often pair pick play room see sell sit speak smile sister think then walk water work write woman yes";
        string[] words = text.Split();
        foreach(string el in words)
            dictionary.Add(el, true);
        
        Console.WriteLine("Enter a word to check:");
        string word = Console.ReadLine();

        if (dictionary.Contains(word))
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("WrongSpelling");
        }
    }
}

public class HashTable<KItem, VItem>
{
    private const int DefaultCapacity = 50;
    private LinkedList<KeyValuePair<KItem, VItem>>[] buckets;

    public HashTable()
    {
        buckets = new LinkedList<KeyValuePair<KItem, VItem>>[DefaultCapacity];
    }
    public HashTable(int initialCapacity)
    {
        buckets = new LinkedList<KeyValuePair<KItem, VItem>>[initialCapacity];
    }
    private int GetHash(KItem key)
    {
        return Math.Abs(key.GetHashCode()) % buckets.Length;
    }
    public void Add(KItem key, VItem value)
    {
        int index = GetHash(key);
        if (buckets[index] == null)
            buckets[index] = new LinkedList<KeyValuePair<KItem, VItem>>();

        foreach (var pair in buckets[index])
        {
            if (pair.Key.Equals(key))
                throw new ArgumentException("An item with the same key already exists in the dictionary.");
        }

        buckets[index].AddLast(new KeyValuePair<KItem, VItem>(key, value));
    }
    public void Remove(KItem key)
    {
        int index = GetHash(key);
        if (buckets[index] != null)
        {
            var node = buckets[index].First;
            while (node != null)
            {
                if (node.Value.Key.Equals(key))
                {
                    buckets[index].Remove(node);
                    return;
                }
                node = node.Next;
            }
        }
    }
    public VItem Get(KItem key)
    {
        int index = GetHash(key);
        if (buckets[index] != null)
        {
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                    return pair.Value;
            }
        }
        return default(VItem);
    }
    public bool Contains(KItem key)
    {
        int index = GetHash(key);
        if (buckets[index] != null)
        {
            foreach (var pair in buckets[index])
            {
                if (pair.Key.Equals(key))
                    return true;
            }
        }
        return false;
    }
    public void Clear()
    {
        Array.Clear(buckets, 0, buckets.Length);
    }
    public int Size()
    {
        int count = 0;
        foreach (var bucket in buckets)
        {
            if (bucket != null)
                count += bucket.Count;
        }
        return count;
    }
}

