using System;

class MatrixToArray
{
    static void Main(string[] args)
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter columns: ");
        int columns = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, columns];
        int[] array = new int[rows * columns];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
                array[index++] = matrix[i, j];
            }
        }

        Console.WriteLine("1D Array:");
        foreach (int value in array)
            Console.Write(value + " ");
    }
}
