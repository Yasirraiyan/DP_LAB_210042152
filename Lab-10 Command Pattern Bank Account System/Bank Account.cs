public class BankAccount
{
    public long accountno;
    public decimal cbalance;
    public decimal amount;
    public List<string> history;
    public bool withdraw=false;
    public BankAccount(long accountno, decimal cbalance, decimal amount)
    {
        this.accountno = accountno;
        this.cbalance = cbalance;
        this.amount = amount;
    }
    public decimal deposit(decimal amount)
    {
        decimal deposit=amount+cbalance;
        history.Add($"Deposited:{amount}");
        return deposit;
       
    }
    public (decimal,bool) withdrawal(decimal amount,decimal cbalance,bool withdraw)
    {
        if (amount < cbalance)
        {
            withdraw = true;
        }
        else
        {
            withdraw = false;
        }
        cbalance=cbalance-amount;
        history.Add($"Withdrawed:{amount}");
        return (cbalance,withdraw);
      
    }
    public decimal withdrew(decimal amount,decimal cbalance)
    {
        decimal withdraw= amount - cbalance;
        history.Add($"Deposited:{amount}");
        return  withdraw;
        
    }
    public void showhistory()
    {
        foreach(var item in history)
        {
            Console.WriteLine(item);
        }
    }
}
