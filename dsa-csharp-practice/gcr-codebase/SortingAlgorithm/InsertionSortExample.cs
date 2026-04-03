using System;

class InsertionSortExample
{
    static void InsertionSort(int[] ids)
    {
        for (int i = 1; i < ids.Length; i++)
        {
            int key = ids[i];
            int j = i - 1;

            while (j >= 0 && ids[j] > key)
            {
                ids[j + 1] = ids[j];
                j--;
            }
            ids[j + 1] = key;
        }
    }

    static void Main()
    {
        int[] ids = { 105, 102, 110, 101 };
        InsertionSort(ids);

        Console.WriteLine("Sorted Employee IDs:");
        foreach (int id in ids)
            Console.Write(id + " ");
    }
}
