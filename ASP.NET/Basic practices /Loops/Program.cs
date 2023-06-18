using System;


class Program
{
    static void Main(string[] args)
    {
        // For loop
        Console.WriteLine("For loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine();

        // While loop
        Console.WriteLine("While loop:");
        int j = 0;
        while (j < 5)
        {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine();

        // Do-while loop
        Console.WriteLine("Do-While loop:");
        int k = 0;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k < 5);

        Console.WriteLine();

        // Nested loop
        Console.WriteLine("Nested loop:");
        for (int m = 1; m <= 3; m++)
        {
            for (int n = 1; n <= 3; n++)
            {
                Console.WriteLine($"m: {m}, n: {n}");
            }
        }

        Console.WriteLine();

        // Foreach loop
        Console.WriteLine("Foreach loop:");
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        // Break statement
        Console.WriteLine("Break statement:");
        for (int p = 1; p <= 5; p++)
        {
            if (p == 3)
            {
                break;
            }
            Console.WriteLine(p);
        }

        Console.WriteLine();

        // Continue statement
        Console.WriteLine("Continue statement:");
        for (int q = 1; q <= 5; q++)
        {
            if (q == 3)
            {
                continue;
            }
            Console.WriteLine(q);
        }
    }
}