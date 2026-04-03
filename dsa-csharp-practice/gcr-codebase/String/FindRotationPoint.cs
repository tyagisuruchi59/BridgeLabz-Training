using System;

class FindRotationPoint
{
    static void Main()
    {
        int[] arr = { 4, 5, 6, 1, 2, 3 };
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = (left + right) / 2;
            if (arr[mid] > arr[right])
                left = mid + 1;
            else
                right = mid;
        }

        Console.WriteLine("Rotation Index: " + left);
    }
}
