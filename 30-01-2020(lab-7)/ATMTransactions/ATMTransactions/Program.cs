using System;

namespace ATMTransactions
{
    class Account
    {
        int no = 1;
        string name = "Sai Hemanth";
        double bal = 10000;

        public double checkBalance()
        { return bal; }

        public double deposit(double amt)
        {
            bal += amt;
            return bal;
        }

        public double withdraw(double amt)
        {
            if (bal < amt)
                return -1;

            bal -= amt;
            return bal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            Console.WriteLine("Welcome to XYZ Bank\n==================================================\n");
            int op = -1;
            double amt;

            while (op != 4)
            {
                Console.Write("Options:\n1) Check Balance\n2) Deposit\n3) Withdraw\n4) Exit\nEnter Option: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine($"Your Account Balance: {acc.checkBalance()}");
                        break;

                    case 2:
                        Console.Write("Enter Amount to Deposit: ");
                        amt = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Balance after depositing {amt} is {acc.deposit(amt)}");
                        break;

                    case 3:
                        Console.Write("Enter Amount to Withdraw: ");
                        amt = double.Parse(Console.ReadLine());
                        double bal = acc.withdraw(amt);

                        if (bal == -1)
                            Console.WriteLine("Balance Insufficient.");
                        else
                            Console.WriteLine($"Balance after withdrawing {amt} is {bal}");
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.WriteLine();
            }

            Console.WriteLine("Exiting");
        }
    }
}
