using System;

class Program
{
    static void Main(string[] args)
    {
        //You are given an array of strings. 
        //Write a method that sorts the array by the length of its elements (the number of characters composing them).

        Console.WriteLine("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());
        string[] textToCompare = new string[size];

        for (int i = 0; i < textToCompare.Length; i++)
        {
            Console.Write("Line {0} = ", i + 1);
            textToCompare[i] = Console.ReadLine();
        }
        Console.WriteLine();
        for (int i = 0; i < textToCompare.Length; i++)
        {
            Console.WriteLine("Before sort: {0}", textToCompare[i]);
        }

        Array.Sort(textToCompare, (x, y) => x.Length.CompareTo(y.Length));
        
        for (int i = 0; i < textToCompare.Length; i++)
        {
            Console.WriteLine("\nAfter sort: {0}", textToCompare[i]);
        }
    }
}

