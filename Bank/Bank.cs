using System.Collections.Generic;

namespace Bank
{
    internal static class Bank
    {
        private static List<User> _users = new List<User> { };

        public static string ShowAllAccountsBalances()
        {
            string message = "";
            foreach (User user in Bank._users)
            {
                foreach (Account account in user.Accounts)
                {
                    message += account.ShowBalance();
                }
            }
            return message;
        }

        public static void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}