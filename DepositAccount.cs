namespace BankSimulation
{
    using System;
    
    class DepositAccount : Account, IFullyFunctionable
    {
        public DepositAccount(Client client, decimal accountBalance, decimal monthInterestRate)
            : base (client, accountBalance, monthInterestRate)
        {

        }

        public void DepositMoney(decimal moneyToDeposit)
        {
            this.AccountBalance += moneyToDeposit;
        }

        public decimal WithdrawMoney(decimal moneyToWithdraw)
        {
            if (moneyToWithdraw > this.AccountBalance)
            {
                throw new InvalidOperationException("Not enough money in the account!");
            }

            AccountBalance -= moneyToWithdraw;

            return moneyToWithdraw;
        }

        public override decimal CalculateTotalInterestRateForCertainPeriond(int monthsCount)
        {
            decimal currInterestRate = this.MonthInterestRate;
            if (this.AccountBalance >= 0 && this.AccountBalance < 1000)
            {
                currInterestRate = 0.0m;
            }

            return currInterestRate;
        }
    }
}
