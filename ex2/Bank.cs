namespace ex2;
public class Bank<T> where T : Account
{
    private List<T> _accounts = new List<T>();
    
    public void AddAccount(T account)
    {
        _accounts.Add(account);
    }
    
    public void ShowAccountInfo()
    {
        foreach (T account in _accounts)
        {
            account.ShowInfo();
        }
    }
}