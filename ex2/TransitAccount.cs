namespace ex2;

public class TransitAccount : Account
{
    public TransitAccount(string accountName, decimal balance)
        : base(accountName, balance)
    {
    }
    
    public override void ShowInfo()
    {
        Console.WriteLine($"Транзитный счёт: {AccountName}, Баланс: {Balance}.");
    }
}