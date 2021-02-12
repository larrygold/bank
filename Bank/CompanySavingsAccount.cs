namespace Bank
{
    internal class CompanySavingsAccount : Account
    {
        private double contributionRate;
        private string friendlyName = "compte épargne entreprise";

        public CompanySavingsAccount(User user, double contributionRate) : base(user)
        {
            this.contributionRate = contributionRate;
        }

        public override string ShowBalance() => $"Solde {friendlyName} de {user.Name} : {balance} \n";

        public void PayContributionRate() => Credit(balance * contributionRate);

        public override string ShowAccountSummary()
        {
            string message = $"Résumé du {friendlyName} de {user.Name} \n *************************** \n";
            message += base.ShowAccountSummary();
            message += $"Taux d'abondement : {contributionRate} \n";

            return message;
        }
    }
}