using System;
using PrivateProtected.assembly;

namespace PrivateProtected
{
    public class PrivateProtect
    {
        public string s0 = "1.public member";
        private protected string s = "2.private protected member";
        internal string s1 = "3.internal member";
        protected string s2 = "4.protected member";
        protected internal string s3 = "5.protected internal member";
        private string s4 = "6.private member";
        public class A
        {
            public void getInfo()
            {
                PrivateProtect p = new PrivateProtect();
                Console.WriteLine("within class: \n" + p.s0 + ",\n" +
                p.s + ",\n" + p.s1 + ",\n" + p.s2 + ",\n" + p.s3 + ",\n" + p.s4 + "\n\n\n");
                //accessable within class
            }
        }

        public void print()
        {
            A obj = new A();
            obj.getInfo();            //accessable within class


        }

        protected class p
        {

        }

    }
    //derieved class
    class B : PrivateProtect
    {

        public void print1()
        {
            Console.WriteLine("Derived Class: \n" + s0 + ",\n" + s + ",\n"
                                  + s1 + ",\n" + s2 + ",\n" + s3 + "\n\n\n");
            // accessable from derived class same assembly


        }


    }

    class D : DifferentAsm
    {


        // accessable from derived class different assembly
        public void print3()
        {
            Console.WriteLine("Derived class different assembly: \n" + s0 + ",\n" + s
                + ",\n" + s2 + ",\n" + "\n\n\n");
        }
    }



    class Program
    {
        public static void Main(string[] args)
        {
            PrivateProtect within = new PrivateProtect();
            //within class
            within.print();

            B derived = new B();
            //derived class same assembly
            derived.print1();

            //non derieved class same assembly
            Console.WriteLine("Non derived class(same Assembly): \n" + derived.s0 + ",\n" /*+ obj.s + ",\n"*/
                                  + derived.s1 + ",\n" +/*obj.s2 + ",\n" +*/ derived.s3 + "\n\n\n"); // accessable from derived class(private protected)
            //derived class different assembly
            D dd = new D();
            dd.print3();
            //non derieved class different assembly
            NonDerivedClass ob2 = new NonDerivedClass();
            Console.WriteLine("non derieved class different assembly: \n" + ob2.s0 + " \n\n\n");

        }
    }

}