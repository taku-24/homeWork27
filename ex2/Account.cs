namespace ex2;

public class Account
{
    public string AccountName { get; set; }
    public decimal Balance { get; set; }

    public Account(string accountName, decimal balance)
    {
        AccountName = accountName;
        Balance = balance;
    }
    
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Счёт: {AccountName}, Баланс: {Balance}.");
    }
}