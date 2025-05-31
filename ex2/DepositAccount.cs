namespace ex2;
public class DepositAccount : Account
{
    public DepositAccount(string accountName, decimal balance)
        : base(accountName, balance)
    {
    }
    
    public override void ShowInfo()
    {
        Console.WriteLine($"Депозитный счёт: {AccountName}, Баланс: {Balance}.");
    }
}