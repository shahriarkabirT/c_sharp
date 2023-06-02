class BaseClass{

    public virtual void print() {

        Console.WriteLine("This is from base class");

    }

}
class Child : BaseClass {
    public override void print()
    {
    
        Console.WriteLine("This is from child class");
        base.print();
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        Child c = new Child();
        c.print();
    }
}