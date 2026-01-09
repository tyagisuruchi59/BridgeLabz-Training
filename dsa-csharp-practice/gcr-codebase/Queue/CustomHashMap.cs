using System;
using System.Collections.Generic;

namespace DSA_CustomHashMap
{
    // Node to store key-value pairs
    class HashNode
    {
        public int Key;
        public int Value;

        public HashNode(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }

    class CustomHashMap
    {
        private readonly int SIZE = 10;
        private LinkedList<HashNode>[] buckets;

        public CustomHashMap()
        {
            buckets = new LinkedList<HashNode>[SIZE];

            for (int i = 0; i < SIZE; i++)
            {
                buckets[i] = new LinkedList<HashNode>();
            }
        }

        // Hash function
        private int GetBucketIndex(int key)
        {
            return key % SIZE;
        }

        // Insert or Update
        public void Put(int key, int value)
        {
            int index = GetBucketIndex(key);

            foreach (var node in buckets[index])
            {
                if (node.Key == key)
                {
                    node.Value = value; // Update
                    return;
                }
            }

            buckets[index].AddLast(new HashNode(key, value));
        }

        // Get value by key
        public int Get(int key)
        {
            int index = GetBucketIndex(key);

            foreach (var node in buckets[index])
            {
                if (node.Key == key)
                {
                    return node.Value;
                }
            }

            return -1; // Key not found
        }

        // Remove key-value pair
        public bool Remove(int key)
        {
            int index = GetBucketIndex(key);

            var list = buckets[index];
            var current = list.First;

            while (current != null)
            {
                if (current.Value.Key == key)
                {
                    list.Remove(current);
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        // Display HashMap
        public void Display()
        {
            for (int i = 0; i < SIZE; i++)
            {
                Console.Write($"Bucket {i}: ");
                foreach (var node in buckets[i])
                {
                    Console.Write($"[{node.Key}:{node.Value}] ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CustomHashMap map = new CustomHashMap();

            map.Put(1, 100);
            map.Put(2, 200);
            map.Put(11, 1100); // Collision with key 1
            map.Put(3, 300);

            Console.WriteLine("HashMap Contents:");
            map.Display();

            Console.WriteLine("\nGet Key 2: " + map.Get(2));
            Console.WriteLine("Remove Key 1: " + map.Remove(1));

            Console.WriteLine("\nHashMap After Removal:");
            map.Display();

            Console.ReadLine();
        }
    }
}
