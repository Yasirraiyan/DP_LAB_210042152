class Program
{
    public static void Main(string[] args)
    {
       
        Context c1 = new Context();
        c1.setpaymentstrategy(new CreditCard(123));
        c1.payamount(1000);
        c1.setpaymentstrategy(new Paypal("yasir 123 @ yahoo.com"));
        c1.payamount(500);
        c1.setpaymentstrategy(new Crypto("01407841543"));
    
        c1.payamount(300);


    }
}
