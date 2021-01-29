﻿namespace Bank
{
    internal class CurrentAccount : Account
    {
        private double authorisedOverdraft;
        private string friendlyName = "compte courant";

        public CurrentAccount(User user, double authorisedOverdraft) : base(user)
        {
            this.authorisedOverdraft = authorisedOverdraft;
        }

        public override string ShowBalance() => $"Solde {friendlyName} de {user.name} : {balance} \n";

        public override string ShowAccountSummary()
        {
            string message = $"Résumé du {friendlyName} de {user.name} \n *************************** \n";
            message += base.ShowAccountSummary();
            message += $"Découvert autorisé : {authorisedOverdraft} \n";

            return message;
        }
    }
}