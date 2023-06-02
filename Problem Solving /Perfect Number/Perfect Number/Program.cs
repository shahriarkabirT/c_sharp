using System;
namespace perfectNum
{ 
    class P {
      public void perfectN(int n) {
            
            for(int i = 2 ; i <= n; i++) {
                int temp = 0;
                for(int j = 1; j < i; j++) {
                    
                    if (i % j == 0)
                    {
                        temp += j;
                    }
                }
                if(temp == i)
                { 
                    Console.Write(temp+"\n");
              
                }
            }

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a range for producing perfect number:");
            n = Convert.ToInt32(Console.ReadLine());
            P p = new P();
            p.perfectN(n);

        }
    }
}