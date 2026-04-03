using System;
using System.Collections.Generic;

namespace Queues
{
    public class QueueProblems
    {
        public static void Run()
        {
            ReverseQueue();
            BinaryNumbers();
            HospitalTriage();
        }

        static void ReverseQueue()
        {
            Queue<int> q = new(new[] { 10, 20, 30 });
            Stack<int> stack = new(q);

            q.Clear();
            foreach (var i in stack)
                q.Enqueue(i);

            Console.WriteLine("Reversed Queue: " + string.Join(",", q));
        }

        static void BinaryNumbers()
        {
            int n = 5;
            Queue<string> q = new();
            q.Enqueue("1");

            for (int i = 0; i < n; i++)
            {
                string s = q.Dequeue();
                Console.WriteLine(s);
                q.Enqueue(s + "0");
                q.Enqueue(s + "1");
            }
        }

        static void HospitalTriage()
        {
            PriorityQueue<string, int> pq = new();
            pq.Enqueue("John", -3);
            pq.Enqueue("Alice", -5);
            pq.Enqueue("Bob", -2);

            Console.WriteLine("Treatment Order:");
            while (pq.Count > 0)
                Console.WriteLine(pq.Dequeue());
        }
    }
}
