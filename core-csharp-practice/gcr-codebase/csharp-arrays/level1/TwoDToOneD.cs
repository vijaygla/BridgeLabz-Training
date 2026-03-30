// Working with Multi-Dimensional Arrays. Write a C# program to create a 2D Array and Copy the 2D Array into a single dimension array

using System;

class TwoDToOneD {
    static void Main(string[] args) {
        Console.Write("Enter rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        int[] array = new int[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write("Enter element: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
                array[index++] = matrix[i, j];
            }
        }

        Console.WriteLine("1D Array:");
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
    }
}
