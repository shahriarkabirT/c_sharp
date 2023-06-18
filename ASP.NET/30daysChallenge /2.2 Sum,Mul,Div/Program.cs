using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter an integer: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a double: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double sumResult = Sum(num1, num2);
        double additionResult = Addition(num1, num2);
        double multiplicationResult = Multiplication(num1, num2);

        Console.WriteLine("Sum Result: " + sumResult);
        Console.WriteLine("Addition Result: " + additionResult.ToString("F2"));
        Console.WriteLine("Multiplication Result: " + multiplicationResult.ToString("F2"));
    }
    static double Sum(int a, double b)
    {
        return (double)a + b;
    }
    static double Addition(int a, double b)
    {
        return a + b;
    }

    static double Multiplication(int a, double b)
    {
        return a * b;
    }
}
