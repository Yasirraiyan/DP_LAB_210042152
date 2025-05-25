 public class Context
 {
     IPaymentStrategy _strategy;
     public void setpaymentstrategy(IPaymentStrategy strategy)
     {
         _strategy = strategy;
     }
     public void payamount(int amount)
     {
         if(_strategy == null)

         {
             Console.WriteLine("Not paying amount");
         }
         else
         {
             _strategy.pay(amount);

         }
     }
 }
