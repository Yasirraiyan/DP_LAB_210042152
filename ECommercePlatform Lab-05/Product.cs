public class Product:IProduct
{
    public string name { get; set; }
    public string description { get; set; }
    public double price { get; set; }
    public double discount { get; set; }

    public Product(string name, string description, double price)
    {
        this.name = name;
       this. description = description;
        this.price = price;
    }

    public double getprice()
    {
        return price;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        Console.WriteLine($"Price: ${price:0.00}"); 
    }
    public string getname()
    {
        return name;
    }

}
