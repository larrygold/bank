using System.Text;

namespace Bank
{
    internal class CompanySavingsAccount : Account
    {
        private double _contributionRate;
        private string _friendlyName = "compte épargne entreprise";

        public CompanySavingsAccount(User user, double contributionRate) : base(user)
        {
            this._contributionRate = contributionRate;
        }

        public override string ShowBalance() => $"Solde {_friendlyName} de {User.Name} : {Balance} \n";

        public void PayContributionRate() => Credit(Balance * _contributionRate);

        public override string ShowAccountSummary()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Résumé du {_friendlyName} de {User.Name} \n *************************** \n");
            sb.Append(base.ShowAccountSummary());
            sb.Append($"Taux d'abondement : {_contributionRate} \n");

            return sb.ToString();
        }
    }
}