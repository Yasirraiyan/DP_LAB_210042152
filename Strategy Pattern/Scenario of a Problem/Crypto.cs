public class Crypto : IPaymentStrategy
 {
     public string phn;
     public Crypto(string phn)

     {
         this.phn = phn;
     }
         public void pay(int amount)

     {
         Console.WriteLine($"Paid by crypto for the card:{phn}");
     }

 }
