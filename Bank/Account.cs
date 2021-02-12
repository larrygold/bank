using System.Collections.Generic;

namespace Bank
{
    internal abstract class Account
    {
        protected User User;
        protected double Balance;
        private List<Operation> _operations = new List<Operation> { };

        private Account(User user)
        {
            this.User = user;
            Balance = 0.0;
            user.AddAccount(this);
        }


        public abstract string ShowBalance();

        public virtual string ShowAccountSummary()
        {
            string message = "";
            message += $"Solde : {Balance} \n \n";
            message += "Liste des opérations : \n";
            foreach (Operation operation in _operations)
            {
                ShowOperation(operation);
            }
            message += "\n";

            return message;
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
            string message = "";
            if (operation.MovementType == Movement.Debit)
            {
                message += "-";
            }
            message += $"{operation.Amount} \n";
            return message;
        }
    }
}