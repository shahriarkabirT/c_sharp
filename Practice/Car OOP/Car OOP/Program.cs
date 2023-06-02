using System;

namespace lab_report_2
{
    public class Vehicle
    {
        string brand, model, year, fuel_type;
        public void setValue(string brand, string model, string year, string fuel_type)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.fuel_type = fuel_type;
        }
        public void print()
        {
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("model : " + model);
            Console.WriteLine("year : " + year);
            Console.WriteLine("fuel_type : " + fuel_type);

            Console.WriteLine("**************");
        }
    }
    public class Truck : Vehicle
    {

        public Truck()
        {
            setValue("Axial RC Truck", "SCX6", "2014", "Petrol");
            print();
        }
    }

    public class Car : Vehicle
    {
        public Car()
        {
            setValue("Toyota", "482", "2004", "GAS");
            print();
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            setValue("Suzuki", "Gixxer", "2021", "Octene");
            print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Truck truck = new Truck();
            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();
        }

    }
}