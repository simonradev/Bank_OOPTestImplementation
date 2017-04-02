namespace BankSimulation
{
    public abstract class Account
    {
        private Client client;
        private decimal accountBalance;
        private decimal monthInterestRate;

        public Account(Client client, decimal accountBalance, decimal monthInterestRate)
        {
            this.client = client;
            this.accountBalance = accountBalance;
            this.monthInterestRate = monthInterestRate;
        }

        public Client Client
        {
            get { return this.client; }
        }

        public decimal AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public decimal MonthInterestRate
        {
            get { return this.monthInterestRate; }
        }

        public abstract decimal CalculateTotalInterestRateForCertainPeriond(int monthsCount);
    }
}
