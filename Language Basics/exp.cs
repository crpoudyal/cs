using System;

namespace LanguageBasics
{
    public class exp
    {
        public static void Main(String[] args)
        {
            exp e = new exp();
            e.checkAmount();
        }

        public int balance, withdrawBalance, rem;
        public void checkAmount()
        {
            Console.WriteLine("Enter Your Total Balance in Bank");
            balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Withdraw amount from Bank");
            withdrawBalance = int.Parse(Console.ReadLine());
            Console.WriteLine("Balance is " + balance + " WithdrawAmount is " + withdrawBalance);
            if (balance > withdrawBalance)
            {
                balance = balance - withdrawBalance;
                rem = balance;
                Console.WriteLine("Remaining Balance is {0}", rem);
            }
            else
            {
                throw new ArithmeticException("Insufficient funds");
            }
        }
    }
}