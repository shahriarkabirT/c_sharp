
// C# program to illustrate the
// concept of interface
using System;

// A simple interface
interface interface1
{

    // method having only declaration
    // not definition
    void show();
}

// A class that implements the interface.
class MyClass : interface1
{

    // providing the body part of function
    public void show()
    {
        Console.WriteLine (" Welcome to Shahriar Zone ");
    }

    // Main Method
    public static void Main (String[] args)
    {

        // Creating object
        MyClass obj1 = new MyClass();

        // calling method
        obj1.show();

    }
}