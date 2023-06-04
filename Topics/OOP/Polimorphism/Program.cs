using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }

    public void Draw(int sides)
    {
        Console.WriteLine($"Drawing a shape with {sides} sides.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape shape = new Shape();
        shape.Draw();           // Calls the virtual Draw() method in the Shape class

        Circle circle = new Circle();
        circle.Draw();          // Calls the overridden Draw() method in the Circle class

        shape.Draw(4);          // Calls the overloaded Draw(int sides) method in the Shape class
    }
}