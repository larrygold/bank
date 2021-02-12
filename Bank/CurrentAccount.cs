using System.Text;

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
            StringBuilder sb = new StringBuilder();
            sb.Append($"Résumé du {_friendlyName} de {User.Name} \n *************************** \n");
            sb.Append(base.ShowAccountSummary());
            sb.Append($"Découvert autorisé : {_authorisedOverdraft} \n");

            return sb.ToString();
        }
    }
}