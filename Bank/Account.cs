using System.Collections.Generic;
using System.Text;

namespace Bank
{
    internal abstract class Account
    {
        protected User User;
        protected double Balance;
        private List<Operation> _operations = new List<Operation> { };

        public Account(User user)
        {
            this.User = user;
            Balance = 0.0;
            user.AddAccount(this);
        }

        public abstract string ShowBalance();

        public virtual string ShowAccountSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Solde : {Balance} \n \n").Append("Liste des opérations : \n");

            foreach (Operation operation in _operations)
            {
                sb.Append(ShowOperation(operation));
            }
            sb.Append("\n");

            return sb.ToString();
        }

        public void Credit(double amount, Account debitedAccount)
        {
            Credit(amount);
            debitedAccount.Debit(amount);
        }

        public void Debit(double amount, Account creditedAccount)
        {
            Debit(amount);
            creditedAccount.Credit(amount);
        }

        public void Credit(double amount)
        {
            Balance += amount;
            _operations.Add(new Operation(Movement.Credit, amount));
        }

        public void Debit(double amount)
        {
            Balance -= amount;
            _operations.Add(new Operation(Movement.Debit, amount));
        }

        private string ShowOperation(Operation operation)
        {
            StringBuilder sb = new StringBuilder();
            if (operation.MovementType == Movement.Debit)
            {
                sb.Append("-");
            }
            sb.Append($"{operation.Amount} \n");
            return sb.ToString();
        }
    }
}