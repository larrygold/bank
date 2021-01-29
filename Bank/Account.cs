using System.Collections.Generic;

namespace Bank
{
    internal abstract class Account
    {
        protected User user;
        protected double balance;
        private List<Operation> operations = new List<Operation> { };

        public Account(User user)
        {
            this.user = user;
            balance = 0.0;
            user.AddAccount(this);
        }

        public abstract string ShowBalance();

        public virtual string ShowAccountSummary()
        {
            string message = "";
            message += $"Solde : {balance} \n \n";
            message += "Liste des opérations : \n";
            foreach (Operation operation in operations)
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
            balance += amount;
            operations.Add(new Operation(Movement.Credit, amount));
        }

        public void Debit(double amount)
        {
            balance -= amount;
            operations.Add(new Operation(Movement.Debit, amount));
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