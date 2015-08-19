using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

        Console.WriteLine("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for m: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        int maxSum = int.MinValue;

        Console.WriteLine("Enter numbers separate by space");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string colsLine = Console.ReadLine();
            string[] cells = colsLine.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(cells[col]);
            }
        }

        if (n > 2 || m > 2)
        {
            Console.WriteLine("Invalid matrix");
        }
        else
        {
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] +
                              matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("The maximal sum is: {0}", maxSum);
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        }

    }
}

