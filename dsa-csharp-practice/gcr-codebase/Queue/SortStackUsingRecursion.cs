using System;
using System.Collections.Generic;

namespace DSA_SortStack
{
    class StackSorter
    {
        // Function to sort the stack
        public static void SortStack(Stack<int> stack)
        {
            // Base case
            if (stack.Count <= 1)
                return;

            // Remove top element
            int top = stack.Pop();

            // Sort remaining stack
            SortStack(stack);

            // Insert the popped element in sorted order
            InsertSorted(stack, top);
        }

        // Helper function to insert element in sorted order
        private static void InsertSorted(Stack<int> stack, int value)
        {
            // Base condition
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            // Remove top element
            int temp = stack.Pop();

            // Recursive call
            InsertSorted(stack, value);

            // Push back the removed element
            stack.Push(temp);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(30);
            stack.Push(10);
            stack.Push(50);
            stack.Push(20);

            Console.WriteLine("Original Stack:");
            PrintStack(stack);

            StackSorter.SortStack(stack);

            Console.WriteLine("\nSorted Stack:");
            PrintStack(stack);

            Console.ReadLine();
        }

        // Utility method to print stack
        static void PrintStack(Stack<int> stack)
        {
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
