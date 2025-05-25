public class Paypal:IPaymentStrategy
{
    public string  email;
    public Paypal(string email) 
    { 
        this.email= email;
    }
    public void pay(int amount)
    {

        Console.WriteLine($"Paying {amount} using PayPal account {email}");
    }

}
