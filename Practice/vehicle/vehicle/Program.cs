using System;
namespace vehicle
{

    public class Vehicle
    {
        public string? color;
        public string? brand;
        public string? speed;
        public int noOfWheel;
        public string? value;
        public void setSpeed(string speed)
        {
           this.speed = speed;
        }

        public void printValue()
        {
            Console.WriteLine("\nColor: " + this.color + "\nBrand: " + this.brand + "\nSpeed: " + this.speed +
                "\nNumber of wheel: " + this.noOfWheel + "\nBrandValue: " + this.value);
        }
    }

    class Car : Vehicle
    {

        public void noWheel(int n)
        {
            noOfWheel = n;
        }

    }
    class Cycle : Vehicle
    {
        public void noWheel(int n)
        {
            this.noOfWheel = n;
        }
        public void setValue(string color, string brand, string speed, string value, int noOfwheel)
        {
            base.setSpeed(speed);
            this.color = color;
            this.brand = brand;
            this.value= value;
            noWheel(noOfWheel);
        }
        

    }

    class Toyota : Car
    {

        public void brandValue(string value)
        {
            this.value = value;
        }
        public void setValue(string color, string brand, string speed, string value, int noOfwheel)
        {
            base.setSpeed(speed);
            this.color = color;
            this.brand = brand;
            brandValue(value);
            noWheel(noOfWheel);
        }

    }
    class Axio : Car
    {
        public void brandValue(string value)
        {
            this.value = value;
        }
        public void setValue(string color, string brand, string speed, string value, int noOfwheel)
        {
            base.setSpeed(speed);
            this.color = color;
            this.brand = brand;
            brandValue(value);
            base.noWheel(noOfWheel);
        }
    }
        class Program
        {

            static void Main(string[] args)
            {
                Toyota toyota = new Toyota();
                toyota.setValue("Red", "Toyota", "150kmph", "High", 4);
                toyota.printValue();

                Axio axio = new Axio();
                axio.setValue("Black", "Axio", "200kmph", "Mid", 4);
                axio.printValue();

                Cycle cycle = new Cycle();
                cycle.setValue("Blue", "Suzuki", "150kmph", "high", 4);
                cycle.printValue();
            }
        }
    }
