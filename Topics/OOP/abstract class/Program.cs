// C# program to illustrate the
// concept of abstract class
using System;

// abstract class 'G'
public abstract class G
{

    // abstract method 'gfg1()'
    public abstract void gfg1();

    //can have constructor
   public G()
    {
        Console.WriteLine("CONSTRUCTOR");
    }
    //can contain static member
    public static string st = "Static member";
}

// class 'G' inherit
// in child class 'G1'
public class G1 : G
{

    // abstract method 'gfg1()'
    // declare here with
    // 'override' keyword
    public override void gfg1()
    {
        Console.WriteLine("Class name is G1");
    }
}

// class 'G' inherit in
// another child class 'G2'
public class G2 : G
{

    // same as the previous class
    public override void gfg1()
    {
        Console.WriteLine("Class name is  G2");
    }
}

// Driver Class
public class Program
{

    // Main Method
    public static void Main()
    {

        // 'obj' is object of class
        // 'G' class '
        // G' cannot
        // be instantiate
        G obj;

        // instantiate class 'G1'
        obj = new G1();
        Console.WriteLine(G.st);

        // call 'gfg1()' of class 'G1'
        obj.gfg1();

        // instantiate class 'G2'
        obj = new G2();

        // call 'gfg1()' of class 'G2'
        obj.gfg1();
    }
}

//credit : geeksforgeeks