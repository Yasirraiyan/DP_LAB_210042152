public class Withdraw :ICommand
{
    private BankAccount ba;
    private decimal amount;
    private decimal cbalance;
    public Withdraw(BankAccount ba, decimal amount)
    {
        this.ba = ba;
        this.amount = amount;
        
    }

    public void Execute()
    {
        ba.withdrew(amount,cbalance);
    }
}
