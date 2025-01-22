using System;

namespace ATM_Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000;
            int choice;
            int pinNumber;

            int withdraw, deposit;
            Console.WriteLine("Enter your PinNumber:");
            pinNumber = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("\n1- Check Balance");
                Console.WriteLine("2- Withdraw");
                Console.WriteLine("3- Deposit");
                Console.WriteLine("4- Quit");

                Console.Write("\nEnter your Choice Please: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"The Balance is: {amount}");
                        break;

                    case 2:
                        Console.Write("\nEnter Withdrawal Amount: ");
                        withdraw = int.Parse(Console.ReadLine());

                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("Invalid Amount (must be in multiples of 100).");
                        }
                        else if (withdraw > amount)
                        {
                            Console.WriteLine("Insufficient Balance.");
                        }
                        else
                        {
                            amount -= withdraw;
                            Console.WriteLine($"Your New Balance: {amount}");
                        }
                        break;

                    case 3:
                        Console.Write("\nEnter the Amount to Deposit: ");
                        deposit = int.Parse(Console.ReadLine());
                        amount += deposit;
                        Console.WriteLine($"Your Balance is: {amount}");
                        break;

                    case 4:
                        Console.WriteLine("\nTHANK YOU FOR USING THE ATM!");
                        return; // Exits the program

                    default:
                        Console.WriteLine("Invalid Choice. Please try again.");
                        break;
                }
            }
        }
    }
}
