namespace Bank
{
    internal class CurrentAccount : Account
    {
        private double _authorisedOverdraft;
        private string _friendlyName = "compte courant";

        public CurrentAccount(User user, double authorisedOverdraft) : base(user)
        {
            this._authorisedOverdraft = authorisedOverdraft;
        }

        public override string ShowBalance() => $"Solde {_friendlyName} de {User.Name} : {Balance} \n";

        public override string ShowAccountSummary()
        {
            string message = $"Résumé du {_friendlyName} de {User.Name} \n *************************** \n";
            message += base.ShowAccountSummary();
            message += $"Découvert autorisé : {_authorisedOverdraft} \n";

            return message;
        }
    }
}