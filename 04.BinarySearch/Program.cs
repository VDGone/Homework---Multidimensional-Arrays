using System;

class Program
{
    static void Main(string[] args)
    {
        //Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the
        //method Array.BinSearch() finds the largest number in the array which is ≤ K.

        Console.WriteLine("Enter size of array: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for K: ");
        int k = int.Parse(Console.ReadLine());
        int[] myArr = new int[n];
        int number = 0;

        for (int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("Array[{0}] = ", i);
            myArr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(myArr);
        for (int i = 0; i < myArr.Length; i++)
        {
            if (myArr[i] <= k)
            {
                number = myArr[i];
            }
        }
        Array.BinarySearch(myArr, k);
        if (k < myArr[0])
        {
            Console.WriteLine("K is the smallest number in array", k);
        }
        else
        {
            Console.WriteLine("{0} <= {1} ", number, k);
        }
    }
}

