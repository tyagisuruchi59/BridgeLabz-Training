using System;

class CountingSortExample
{
    static void CountingSort(int[] ages)
    {
        int min = 10, max = 18;
        int[] count = new int[max - min + 1];

        foreach (int age in ages)
            count[age - min]++;

        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            while (count[i]-- > 0)
                ages[index++] = i + min;
        }
    }

    static void Main()
    {
        int[] ages = { 15, 12, 18, 10, 14 };
        CountingSort(ages);

        Console.WriteLine("Sorted Student Ages:");
        foreach (int a in ages)
            Console.Write(a + " ");
    }
}
