using System;

public class Shahriar
{
    private double sgpa1;
    private double sgpa2;
    private double sgpa3;

    public void shahriar2110(double sgpa1, double sgpa2, double sgpa3)
    {
        this.sgpa1 = sgpa1;
        this.sgpa2 = sgpa2;
        this.sgpa3 = sgpa3;
    }

    public double CalculateCGPA()
    {
        double CGPA = (sgpa1 + sgpa2 + sgpa3) / 3.0;
        return CGPA;
        ;
    }
}
public class Program
{
    public static void Main()
    {
        Shahriar cgpaCalculator = new Shahriar();

        Console.WriteLine("Enter SGPA for Semester 1:");
        double sgpa1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter SGPA for Semester 2:");
        double sgpa2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter SGPA for Semester 3:");
        double sgpa3 = Convert.ToDouble(Console.ReadLine());

        cgpaCalculator.shahriar2110(sgpa1, sgpa2, sgpa3);

        double CGPA = cgpaCalculator.CalculateCGPA();

        Console.WriteLine("CGPA: " + CGPA);
    }
}