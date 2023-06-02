using System;

namespace lab_report_2
{
    public class Laptop
    {
        string name;
        string price;
        string processor;
        string ram;
        string hdd;
        public Laptop(string name, string price, string processor, string ram, string hdd)
        {
            this.name = name;
            this.price = price;
            this.processor = processor;
            this.ram = ram;
            this.hdd = hdd;
        }

        public void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Processor: " + processor);
            Console.WriteLine("Ram: " + ram);
            Console.WriteLine("HDD: " + hdd);
            Console.WriteLine("**************");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Laptop lenovo = new Laptop("Dell", "$1500", "i5", "4GB", "1TB");
            lenovo.print();

            Laptop dell = new Laptop("Dell", "$1500", "i5", "4GB", "1TB");
            dell.print();

            Laptop sony = new Laptop("Sony", "$2000", "i9", "8GB", "1TB");
            sony.print();
        }
    }
}