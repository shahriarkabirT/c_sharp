using System;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 5;

        // If statement
        if (num1 > num2)
        {
            Console.WriteLine("num1 is greater than num2");
        }

        // If-else statement
        if (num1 < num2)
        {
            Console.WriteLine("num1 is less than num2");
        }
        else
        {
            Console.WriteLine("num1 is not less than num2");
        }

        // If-else if-else statement
        if (num1 > num2)
        {
            Console.WriteLine("num1 is greater than num2");
        }
        else if (num1 < num2)
        {
            Console.WriteLine("num1 is less than num2");
        }
        else
        {
            Console.WriteLine("num1 is equal to num2");
        }

        // Switch statement
        int option = 2;
        switch (option)
        {
            case 1:
                Console.WriteLine("Option 1 selected");
                break;
            case 2:
                Console.WriteLine("Option 2 selected");
                break;
            case 3:
                Console.WriteLine("Option 3 selected");
                break;
            default:
                Console.WriteLine("Invalid option selected");
                break;
        }

        // Ternary operator
        string message = (num1 > num2) ? "num1 is greater than num2" : "num1 is not greater than num2";
        Console.WriteLine(message);

        // Nested if statement
        if (num1 > num2)
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine("num1 is greater than num2 and even");
            }
            else
            {
                Console.WriteLine("num1 is greater than num2 but not even");
            }
        }
        else
        {
            Console.WriteLine("num1 is not greater than num2");
        }
    }
}