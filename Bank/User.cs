using System.Collections.Generic;

namespace Bank
{
    internal class User
    {
        public string Name;
        public List<Account> Accounts = new List<Account> { };

        public User(string name)
        {
            this.Name = name;
            Bank.AddUser(this);
        }

        public void AddAccount(Account account)
        {
            Accounts.Add(account);
        }
    }
}