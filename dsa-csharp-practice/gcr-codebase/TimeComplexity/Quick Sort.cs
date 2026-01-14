public static void QuickSort(int[] arr, int low, int high)
{
    if (low >= high) return;

    int pivot = Partition(arr, low, high);
    QuickSort(arr, low, pivot - 1);
    QuickSort(arr, pivot + 1, high);
}

private static int Partition(int[] arr, int low, int high)
{
    int pivot = arr[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (arr[j] < pivot)
        {
            i++;
            (arr[i], arr[j]) = (arr[j], arr[i]);
        }
    }
    (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
    return i + 1;
}
