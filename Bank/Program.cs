using System;

namespace Bank
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            User nicolas = new User("Nicolas");
            User jeremie = new User("Jérémie");

            CurrentAccount nicolasCurrentAccount = new CurrentAccount(nicolas, 2000.0);

            CompanySavingsAccount nicolasCompanySavingsAccount = new CompanySavingsAccount(nicolas, 0.02);

            CurrentAccount jeremieCurrentAccount = new CurrentAccount(jeremie, 500.0);

            nicolasCurrentAccount.Credit(100.0);

            nicolasCurrentAccount.Debit(50.0);

            nicolasCompanySavingsAccount.Credit(20.0, nicolasCurrentAccount);

            nicolasCompanySavingsAccount.Credit(100.0);

            nicolasCompanySavingsAccount.Debit(20.0, nicolasCurrentAccount);

            jeremieCurrentAccount.Debit(500.0);

            jeremieCurrentAccount.Debit(200.0, nicolasCurrentAccount);

            nicolasCompanySavingsAccount.PayContributionRate();

            Console.WriteLine(Bank.ShowAllAccountsBalances());

            Console.WriteLine(nicolasCurrentAccount.ShowAccountSummary());

            Console.WriteLine(nicolasCompanySavingsAccount.ShowAccountSummary());

            Console.WriteLine(jeremieCurrentAccount.ShowAccountSummary());

            Console.ReadLine();
        }
    }
}