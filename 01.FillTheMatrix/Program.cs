using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that fills and prints a matrix of size (n, n) as shown below:
        //         Example for n=4:
        //     
        //         a)                   b)                    c)                     d)*
        //         1 5  9 13            1 8  9 16             7 11 14 16             1 12 11 10
        //         2 6 10 14            2 7 10 15             4  8 12 15             2 13 16  9
        //         3 7 11 15            3 6 11 14             2  5  9 13             3 14 15  8
        //         4 8 12 16            4 5 12 13             1  3  6 10             4  5  6  7

        Console.WriteLine("Enter value for arrays size: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int tmpNumber = 1;
        Console.WriteLine("Write a, b, c or d for matrix type you want: ");
        string varMatrices = Console.ReadLine();

        switch (varMatrices)
        {
            case "a":
                #region MatrixA
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {

                        matrix[col, row] = tmpNumber;
                        tmpNumber++;
                    }
                    Console.WriteLine();
                }
                #endregion
                break;
            case "b":
                #region MatrixB
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (row % 2 == 0)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            matrix[col, row] = tmpNumber;
                            tmpNumber++;
                        }
                    }
                    else
                    {
                        for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                        {
                            matrix[col, row] = tmpNumber;
                            tmpNumber++;
                        }
                    }
                }
                #endregion
                break;
            case "c":
                #region MatrixC
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    int tempRow = row;
                    for (int col = 0; col < matrix.GetLength(1) - row; col++)
                    {
                        matrix[tempRow, col] = tmpNumber;
                        tmpNumber++;
                        tempRow++;
                    }
                }
                tmpNumber = n * n;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    int tempRow = row;
                    for (int col = matrix.GetLength(1) - 1; tempRow >= 0; col--)
                    {
                        matrix[tempRow, col] = tmpNumber;
                        tmpNumber--;
                        tempRow--;
                    }
                }
                #endregion
                break;
            case "d":
                #region MatrixD
                int rows = 0;
                int columns = 0;
                int maxRow = n - 1;
                int maxCol = n - 1;
                while (tmpNumber <= n * n)
                {
                    for (int i = rows; i <= maxRow; i++)
                    {
                        matrix[i, columns] = tmpNumber;
                        tmpNumber++;
                    }
                    columns++;

                    for (int i = columns; i <= maxCol; i++)
                    {
                        matrix[maxRow, i] = tmpNumber;
                        tmpNumber++;
                    }
                    maxRow--;

                    for (int i = maxRow; i >=rows; i--)
                    {
                        matrix[i, maxCol] = tmpNumber;
                        tmpNumber++;
                    }
                    maxCol--;

                    for (int i = maxCol; i >= columns; i--)
                    {
                        matrix[rows, i] = tmpNumber;
                        tmpNumber++;
                    }
                    rows++;
                }
                #endregion
                break;
            default:
                Console.WriteLine("No such type!");
                break;
        }
        #region print
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 3}", matrix[row, col]);
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write(", ");
                    tmpNumber++;
                }
            }
            Console.WriteLine();
        }

        #endregion
    }
}

