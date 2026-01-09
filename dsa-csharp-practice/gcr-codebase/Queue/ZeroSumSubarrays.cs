using System;
using System.Collections.Generic;

namespace DSA_HashMap
{
    class ZeroSumSubarrays
    {
        public static void FindZeroSumSubarrays(int[] arr)
        {
            // Dictionary to store prefix sum and its indices
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                // Case 1: Sum is zero from index 0 to i
                if (sum == 0)
                {
                    Console.WriteLine($"Subarray found from index 0 to {i}");
                }

                // Case 2: Sum already exists
                if (map.ContainsKey(sum))
                {
                    foreach (int startIndex in map[sum])
                    {
                        Console.WriteLine($"Subarray found from index {startIndex + 1} to {i}");
                    }
                    map[sum].Add(i);
                }
                else
                {
                    map[sum] = new List<int> { i };
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, -7, 1, 3, -4, -2, -2 };

            Console.WriteLine("Zero Sum Subarrays:");
            ZeroSumSubarrays.FindZeroSumSubarrays(arr);

            Console.ReadLine();
        }
    }
}
