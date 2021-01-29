using System.Collections.Generic;

namespace Bank
{
    internal class User
    {
        public string name;
        public List<Account> accounts = new List<Account> { };

        public User(string name)
        {
            this.name = name;
            Bank.AddUser(this);
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }
    }
}