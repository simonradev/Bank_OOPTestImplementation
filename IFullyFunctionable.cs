namespace BankSimulation
{
    public interface IFullyFunctionable : IDepositable
    {
        decimal WithdrawMoney(decimal moneyToWithdraw);
    }
}
