using System;

namespace ArrayApplication
{
    class MyArray
    {
        static void Main(string[] args)
        {
                                                                                // 1D array
            int[] n = new int[10];
            int[] myArray = { 5, 3 };
          
            /* initialize elements of array n */
            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 100;
            }

            /* output each array element's value */
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("Element[{0}] = {1}", j, n[j]);
            }
            for (int f = 0; f < myArray.Length; f++)
            {
                Console.WriteLine(myArray[f]);
            }








                                                                                //multidimentional array

            int[,] numbers = { { 2, 4 }, { 4, 5 } };

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(numbers[i,j]+ " ");
                }
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }
    }
}