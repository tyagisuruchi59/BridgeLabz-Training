using System;

class SearchIn2DSortedMatrix
{
    static void Main()
    {
        int[,] matrix =
        {
            {1, 3, 5},
            {7, 9, 11}
        };

        int target = 9;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int left = 0, right = rows * cols - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            int value = matrix[mid / cols, mid % cols];

            if (value == target)
            {
                Console.WriteLine("Target Found");
                return;
            }

            if (value < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        Console.WriteLine("Target Not Found");
    }
}
