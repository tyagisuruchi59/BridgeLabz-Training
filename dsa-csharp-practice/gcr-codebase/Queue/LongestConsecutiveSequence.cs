using System;
using System.Collections.Generic;

namespace DSA_HashMap
{
    class LongestConsecutiveSequence
    {
        public static int FindLongestSequence(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in set)
            {
                // Start only if num is the beginning of sequence
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentStreak++;
                    }

                    longest = Math.Max(longest, currentStreak);
                }
            }

            return longest;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };

            int result = LongestConsecutiveSequence.FindLongestSequence(nums);

            Console.WriteLine("Longest Consecutive Sequence Length: " + result);

            Console.ReadLine();
        }
    }
}
