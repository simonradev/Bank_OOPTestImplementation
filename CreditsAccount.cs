namespace BankSimulation
{
    public class CreditsAccount : Account, IDepositable
    {
        public CreditsAccount(Client client, decimal accountBalance, decimal monthInterestRate)
            : base(client, accountBalance, monthInterestRate)
        {

        }

        public void DepositMoney(decimal moneyToDeposit)
        {
            this.AccountBalance += moneyToDeposit;
        }

        public override decimal CalculateTotalInterestRateForCertainPeriond(int monthsCount)
        {
            int monthsWithoutInterestRate = this.Client.ClientType == ClientType.PhysicalUnit ? 3 : 2;

            int monthWithInterestRate = (monthsCount - monthsWithoutInterestRate) > 0 ? (monthsCount - monthsWithoutInterestRate) : 0;

            return this.MonthInterestRate * monthWithInterestRate;
        }
    }
}
