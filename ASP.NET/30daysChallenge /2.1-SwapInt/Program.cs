using System;
namespace Swap
{
 
class Program
    {
        static void Main()
        {
            int a, b;
            int temp;
            Console.WriteLine("Enter Two Number:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Initially \na = " + a+"\n" + "b = " + b);
            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After swapping: \na = " + a + "\n" + "b = " + b);

        }
    }
}

