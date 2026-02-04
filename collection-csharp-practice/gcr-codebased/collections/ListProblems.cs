using System;
using System.Collections;
using System.Collections.Generic;

namespace Lists
{
    public class ListProblems
    {
        public static void Run()
        {
            ReverseArrayList();
            FrequencyOfElements();
            RotateList();
            RemoveDuplicates();
            NthFromEnd();
        }

        static void ReverseArrayList()
        {
            ArrayList list = new ArrayList { 1, 2, 3, 4, 5 };
            int left = 0, right = list.Count - 1;

            while (left < right)
            {
                var temp = list[left];
                list[left] = list[right];
                list[right] = temp;
                left++; right--;
            }

            Console.WriteLine("Reversed ArrayList: " + string.Join(",", list.ToArray()));
        }

        static void FrequencyOfElements()
        {
            List<string> items = new() { "apple", "banana", "apple", "orange" };
            Dictionary<string, int> freq = new();

            foreach (var item in items)
                freq[item] = freq.GetValueOrDefault(item, 0) + 1;

            Console.WriteLine("Frequency:");
            foreach (var kv in freq)
                Console.WriteLine($"{kv.Key} : {kv.Value}");
        }

        static void RotateList()
        {
            List<int> list = new() { 10, 20, 30, 40, 50 };
            int k = 2;

            List<int> rotated = new();
            rotated.AddRange(list.GetRange(k, list.Count - k));
            rotated.AddRange(list.GetRange(0, k));

            Console.WriteLine("Rotated List: " + string.Join(",", rotated));
        }

        static void RemoveDuplicates()
        {
            List<int> list = new() { 3, 1, 2, 2, 3, 4 };
            HashSet<int> seen = new();
            List<int> result = new();

            foreach (int i in list)
                if (seen.Add(i))
                    result.Add(i);

            Console.WriteLine("No Duplicates: " + string.Join(",", result));
        }

        static void NthFromEnd()
        {
            LinkedList<string> list = new(new[] { "A", "B", "C", "D", "E" });
            int n = 2;

            var fast = list.First;
            var slow = list.First;

            for (int i = 0; i < n; i++)
                fast = fast.Next;

            while (fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            Console.WriteLine("Nth from End: " + slow.Value);
        }
    }
}
