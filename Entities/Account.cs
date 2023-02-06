
namespace AulaHerancaEPolimorfismo.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }
        public virtual void Withdraw(double amaunt)
        {
            Balance -= amaunt + 5.00;
        }
        public void Deposit(double amaunt)
        {
            Balance += amaunt;
        }


    }
}
