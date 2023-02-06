using System;
using AulaHerancaEPolimorfismo.Entities;


namespace AulaHerancaEPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1294, "Alex Brown", 200.00);
            Account acc4 = new SavingsAccount(1594, "Maria", 200.00, 0.01);

            acc1.Withdraw(50.00);
            acc4.Withdraw(50.00);
            Console.WriteLine(acc1.Balance.ToString("F2"));
            Console.WriteLine(acc4.Balance.ToString("F2"));

            /*SavingsAccount acc2 = new SavingsAccount(1294, "Alex Stil", 200.00, 0.01);
            acc2.Deposit(100.00);
            Console.WriteLine(acc2.Balance.ToString("F2"));

            acc2.Withdraw(50.00);
            Console.WriteLine(acc2.Balance.ToString("F2"));*/
            Console.ReadLine();
            
        }
    }
}
