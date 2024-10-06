class program
{
    public static void Main(string[] args)
    {
        Bevarage espresso = new Bevarage(500, "Espresso");
        Bevarage latte = new Bevarage(1000, "Latte");

        
        Condiment milk = new Condiment("Milk", 200, 1200, "Fresh Milk");
        Condiment sugar = new Condiment("WhiteSugar", 100, 1100, "Sweetened Sugar");
        Condiment cream = new Condiment("WhippedCream", 2000, 3000, "Creamy Whipped Cream");

        
        Cofeeshop cofeeShop = new Cofeeshop(espresso, "Cafe");

       
        cofeeShop.Add(espresso);
        cofeeShop.Add(latte);

       
        Console.WriteLine("Coffee Shop Type: " + cofeeShop.gettype(cofeeShop.type));
        Console.WriteLine("Available Beverages in Coffee Shop:");
        foreach (var beverage in cofeeShop.Bevarages)
        {
            Console.WriteLine(beverage.getName() + " - " + beverage.getPrice());
        }

        
        Customer customer = new Customer();
        customer.AddCondiment(milk);
        customer.AddCondiment(sugar);

        Console.WriteLine("Customer Condiments:");
        foreach (var condiment in customer.Condiments)
        {
            Console.WriteLine(condiment.gettype(condiment.type) + " - " + condiment.price);
        }

        
        Console.WriteLine("Condiment Price for Milk:");
        milk.getprice(milk.type);

        Console.WriteLine("Condiment Cost for Milk:");
        milk.CalculateCost(milk.type);

        
        Coffee coffeeOrder = new Coffee("Latte", 1000);

      
        coffeeOrder.AddBeverage(latte);
        coffeeOrder.AddCondiment(cream);

       
        Console.WriteLine("Coffee Order: " + coffeeOrder.Type);
        Console.WriteLine("Total Cost of Coffee Order: " + coffeeOrder.GetTotalCost());

       
        coffeeOrder.CalculatePrice(coffeeOrder.Type);
    }
}
