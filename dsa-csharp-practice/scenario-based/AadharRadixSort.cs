using System;

class AadharRadixSort
{
    static void CountingSort(long[] arr, int exp)
    {
        int n = arr.Length;
        long[] output = new long[n];
        int[] count = new int[10];

        for (int i = 0; i < n; i++)
            count[(arr[i] / exp) % 10]++;

        for (int i = 1; i < 10; i++)
            count[i] += count[i - 1];

        for (int i = n - 1; i >= 0; i--)
        {
            int index = (int)((arr[i] / exp) % 10);
            output[count[index] - 1] = arr[i];
            count[index]--;
        }

        for (int i = 0; i < n; i++)
            arr[i] = output[i];
    }

    static void RadixSort(long[] arr)
    {
        long max = arr[0];
        foreach (long num in arr)
            if (num > max) max = num;

        for (int exp = 1; max / exp > 0; exp *= 10)
            CountingSort(arr, exp);
    }

    static void Main()
    {
        long[] aadharNumbers =
        {
            345678912345,
            123456789012,
            345678900001,
            123456700000
        };

        RadixSort(aadharNumbers);

        Console.WriteLine("Sorted Aadhar Numbers:");
        foreach (long num in aadharNumbers)
            Console.WriteLine(num);
    }
}
