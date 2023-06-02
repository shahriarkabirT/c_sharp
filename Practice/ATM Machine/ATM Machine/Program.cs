using System;

class ATM
{
    private decimal balance;

    public ATM(decimal initialBalance = 0)
    {
        balance = initialBalance;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= balance && amount % 500 == 0 && balance - amount >= 500)
        {
            balance -= amount;
            Console.WriteLine("Withdrawal successful. New balance: " + balance);
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current balance: " + balance);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ATM atm = new ATM(1000); // Creating an ATM object with initial balance of 1000

        Console.WriteLine("ATM Initialized.");

        while (true)
        {
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter withdrawal amount: ");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    atm.Withdraw(amount);
                    break;

                case 2:
                    atm.CheckBalance();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}