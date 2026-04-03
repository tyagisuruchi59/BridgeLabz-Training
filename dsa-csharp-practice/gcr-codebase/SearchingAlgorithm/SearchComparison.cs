using System;

class SearchComparison
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }

    static void Main()
    {
        int[] data = { 2, 4, 6, 8, 10, 12, 14 };
        int target = 10;

        Console.WriteLine("Linear Search Index: " + LinearSearch(data, target));
        Console.WriteLine("Binary Search Index: " + BinarySearch(data, target));
    }
}
