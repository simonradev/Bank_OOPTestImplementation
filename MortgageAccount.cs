namespace BankSimulation
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Client client, decimal accountBalance, decimal monthInterestRate)
            : base(client, accountBalance, monthInterestRate)
        {

        }
        
        public void DepositMoney(decimal moneyToDeposit)
        {
            this.AccountBalance += moneyToDeposit;
        }

        public override decimal CalculateTotalInterestRateForCertainPeriond(int monthsCount)
        {
            decimal currentMonthInterstRate = this.Client.ClientType == ClientType.Business ?
                                           this.MonthInterestRate * 0.5m :
                                           0.0m;
            int periodOfTime = this.Client.ClientType == ClientType.Business ? 12 : 6;

            decimal resultForDisscountPeriod = monthsCount * currentMonthInterstRate;
            decimal resultForNonDisscountPeriod = 0.0m;

            if ((this.Client.ClientType == ClientType.Business && monthsCount > 12) ||
                (this.Client.ClientType == ClientType.PhysicalUnit && monthsCount > 6))
            {
                resultForNonDisscountPeriod = (monthsCount - periodOfTime) * this.MonthInterestRate;
            }

            return resultForDisscountPeriod + resultForNonDisscountPeriod;
        }
    }
}
