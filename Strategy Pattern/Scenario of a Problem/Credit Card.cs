 public class CreditCard:IPaymentStrategy
   {
       public int cardno;
       public CreditCard(int cardno)
       {
           this.cardno = cardno;
       }

       public void pay(int amount)
       {
           Console.WriteLine($"Paid by CC the card no:{cardno}");
       }
   }
