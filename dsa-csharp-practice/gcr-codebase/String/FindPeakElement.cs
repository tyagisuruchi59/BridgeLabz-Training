using System;

class FindPeakElement
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1 };
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] < arr[mid + 1])
                left = mid + 1;
            else
                right = mid;
        }

        Console.WriteLine("Peak Element: " + arr[left]);
    }
}
