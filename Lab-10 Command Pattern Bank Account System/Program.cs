class Program
{
    public static void Main(string[] args)
    {
        BankAccount ba = new BankAccount(123456789, 1000, 500);
        ICommand deposit = new Deposit(ba, 500);
        ICommand withdraw = new Withdraw(ba, 200);
        deposit.Execute();
        withdraw.Execute();
        ba.showhistory();
        Console.WriteLine($"Final Balance:{ba.cbalance}");
    }
}

