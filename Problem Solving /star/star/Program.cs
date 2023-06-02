﻿using System;
class Program
{
    static void Main(string[] args)
    {
        int num_rows = 3;


        PrintPattern(num_rows);
    }

    static void PrintPattern(int rows)
    {
        // Upper half of the pattern
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Lower half of the pattern
        for (int i = rows - 1; i >= 1; i--)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}