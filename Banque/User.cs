using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class User
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
