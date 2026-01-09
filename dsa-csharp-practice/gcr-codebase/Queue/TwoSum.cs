using System;
using System.Collections.Generic;

namespace DSA_TwoSum
{
    class TwoSum
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                // Store value and index
                map[nums[i]] = i;
            }

            return new int[] { -1, -1 }; // No solution
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum.FindTwoSum(nums, target);

            Console.WriteLine("Indices: " + result[0] + ", " + result[1]);

            Console.ReadLine();
        }
    }
}
