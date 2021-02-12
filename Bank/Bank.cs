using System.Collections.Generic;
using System.Text;

namespace Bank
{
    internal static class Bank
    {
        private static List<User> _users = new List<User> { };

        public static string ShowAllAccountsBalances()
        {
            StringBuilder sb = new StringBuilder();
            foreach (User user in Bank._users)
            {
                foreach (Account account in user.Accounts)
                {
                    sb.Append(account.ShowBalance());
                }
            }
            return sb.ToString();
        }

        public static void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}