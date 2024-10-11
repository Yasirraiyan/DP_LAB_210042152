public class Bundle : IProduct
{
    public string name { get; set; }
    public string description { get; set; }
    public double discount { get; set; } 
    public List<IProduct> Items { get; set; }
    public double price { get; set; }

    public Bundle(string name, string description, double discount = 0)
    {
        this.name = name;
        this.description = description;
        this.discount = discount;
        Items = new List<IProduct>();
    }

    public double getprice()
    {
       double totalPrice = Items.Sum(item => item.getprice());
        if (discount > 0)
        {
            totalPrice -= totalPrice * (discount / 100); 
        }
        return totalPrice;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        if (discount > 0)
        {
            Console.WriteLine($"Discount: {discount}%");
        }

        Console.WriteLine("Items:");
        foreach (IProduct item in Items)
        {
            item.DisplayDetails();
            Console.WriteLine("----------");
        }
    }
    public string getname()
    {

    return name; 
    }
}
