namespace ex2;

public class ClosedAccount : Account
{
    public ClosedAccount(string accountName, decimal balance)
        : base(accountName, balance)
    {
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Закрытый счёт: {AccountName}, Баланс (бывший): {Balance}.");
    }
}