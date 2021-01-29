using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    static class Bank
    {
        private static List<User> users = new List<User> { };

        public static string ShowAllAccountsBalances()
        {
            string message = "";
            foreach (User user in Bank.users)
            {
                foreach (Account account in user.accounts)
                    message += account.ShowBalance();
            }
            return message;
        }

        public static void AddUser(User user)
        {
            users.Add(user);
        }

    }
}
