using System;

class Program
{
    static void Main(string[] args)
    {
        //We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour 
        //elements located on the same line, column or diagonal.
        //Write a program that finds the longest sequence of equal strings in the matrix.
        //          matrix	     result             matrix         result
        // ha   fifi	ho	hi                       s  qq	s
        // fo	 ha	    hi	xx   ha, ha, ha         pp	pp	s      s, s, s
        //xxx	 ho	    ha	xx                      pp	qq	s 

        Console.WriteLine("Enter value for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for M: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        int currentRow = 0;
        int currentCol = 0;
        int count = 1;
        int maxCount = 0;
        string freq = "";

        Console.WriteLine("Enter strings separated by space.");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string colsLine = Console.ReadLine();
            string[] cells = colsLine.Split(' ');
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = cells[col];
            }
        }

        for (int row = 0;row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] != matrix[currentRow, currentCol] &&
                    matrix[row + 1, col] != matrix[currentRow, currentCol] && matrix[row + 1, col + 1] != matrix[currentRow, currentCol])
                {
                    currentRow = row;
                    currentCol = col;
                    count = 1;
                }
                else if (matrix[row, col] == matrix[currentRow, currentCol] ||
                    matrix[row + 1, col] == matrix[currentRow, currentCol] || matrix[row + 1, col + 1] == matrix[currentRow, currentCol])
                {
                    count += 1;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                    freq = matrix[currentRow, currentCol];
                }
            }
        }
        if (maxCount > 1)
        {
            Console.WriteLine("Most frequent string is: {0} ({1} times.)", freq, maxCount);
        }
        else
        {
            Console.WriteLine("There is no frequent string.");
        }
    }
}

