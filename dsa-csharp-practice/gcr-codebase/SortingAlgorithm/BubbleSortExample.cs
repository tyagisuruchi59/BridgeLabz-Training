using System;

class BubbleSortExample
{
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        int[] marks = { 78, 45, 90, 60, 88 };
        BubbleSort(marks);

        Console.WriteLine("Sorted Student Marks:");
        foreach (int m in marks)
            Console.Write(m + " ");
    }
}
