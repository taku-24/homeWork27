namespace ex2;

public class Program
{
    public static void Main()
    {
        ClosedAccount closedAccount = new ClosedAccount("счет 32", 2000m);
        Bank<TransitAccount> transitBank = new Bank<TransitAccount>();
        
        transitBank.AddAccount(new TransitAccount("Счёт 123", 5000m));
        
        transitBank.ShowAccountInfo();
        
        Bank<DepositAccount> depositBank = new Bank<DepositAccount>();
        depositBank.AddAccount(new DepositAccount("Депозит 234", 15000m));
        depositBank.ShowAccountInfo();
        
        closedAccount.ShowInfo();
    }
}