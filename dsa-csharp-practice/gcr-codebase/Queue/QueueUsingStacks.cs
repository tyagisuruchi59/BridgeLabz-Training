using System;
using System.Collections.Generic;

namespace DSA_QueueUsingStacks
{
    class QueueUsingStacks
    {
        private Stack<int> inputStack;
        private Stack<int> outputStack;

        public QueueUsingStacks()
        {
            inputStack = new Stack<int>();
            outputStack = new Stack<int>();
        }

        // Enqueue operation
        public void Enqueue(int value)
        {
            inputStack.Push(value);
            Console.WriteLine($"Enqueued: {value}");
        }

        // Dequeue operation
        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue.");
                return -1;
            }

            // Move elements if outputStack is empty
            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
            }

            return outputStack.Pop();
        }

        // Peek operation
        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return -1;
            }

            if (outputStack.Count == 0)
            {
                while (inputStack.Count > 0)
                {
                    outputStack.Push(inputStack.Pop());
                }
            }

            return outputStack.Peek();
        }

        // Check if queue is empty
        public bool IsEmpty()
        {
            return inputStack.Count == 0 && outputStack.Count == 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            QueueUsingStacks queue = new QueueUsingStacks();

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Front Element: " + queue.Peek());
            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Dequeued: " + queue.Dequeue());
            Console.WriteLine("Dequeued: " + queue.Dequeue()); // Empty case

            Console.ReadLine();
        }
    }
}
