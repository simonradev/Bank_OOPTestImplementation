namespace BankSimulation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Bank
    {
        private List<Account> allBankAccounts;

        public Bank()
        {
            this.allBankAccounts = new List<Account>();
        }

        public void AddClientAndAccount(Account account)
        {
            if (account == default(Account))
            {
                throw new InvalidOperationException("The client or the account can't be null!");
            }

            this.allBankAccounts.Add(account);
        }

        public string GetReportForAllAccountBalances()
        {
            StringBuilder result = new StringBuilder();
            foreach (Account account in this.allBankAccounts)
            {
                result.AppendLine(
                    $"The client type is {account.Client.ClientType.ToString()} and his account balance is {account.AccountBalance:f2}");
            }

            return result.ToString();
        }

        public string GetReportForAllMonthInterestRatesForPeriodOfTime(int months)
        {
            StringBuilder result = new StringBuilder();
            foreach (Account account in allBankAccounts)
            {
                result.AppendLine($"The total interest rate for the period of {months} months is {account.CalculateTotalInterestRateForCertainPeriond(months)}");
            }

            return result.ToString();
        }
    }
}
