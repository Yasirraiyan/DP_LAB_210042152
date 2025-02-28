public class Deposit : ICommand
 {
     private BankAccount ba;
     private decimal amount;
     public Deposit(BankAccount ba, decimal amount)
     {
         this.ba = ba;
         this.amount = amount;
     }
     public void Execute()
     {
         ba.deposit(amount);
     }
 }
