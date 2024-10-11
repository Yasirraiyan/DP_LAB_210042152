class Program
{
    public static void Main(string[] args)
    {
        
        Product laptop = new Product("Laptop", "High-performance laptop", 1200.00);
        Product phone = new Product("Phone", "Latest smartphone", 800.00);

     
        Bundle holidayGiftBasket = new Bundle("Holiday Gift Basket", "A curated selection of gifts for the holidays", 10); // 10% discount

      
        holidayGiftBasket.Items.Add(laptop);
        holidayGiftBasket.Items.Add(phone);

       
        List<IProduct> allProducts = new List<IProduct>() { laptop, phone, holidayGiftBasket };
        
        Console.WriteLine("Product Information:");
        foreach (IProduct product in allProducts)
        {
            product.DisplayDetails();
            Console.WriteLine("---------");
        }

        Console.WriteLine($"Total Price: $");
    }

}
