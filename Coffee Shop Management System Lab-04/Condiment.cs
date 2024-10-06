public class Condiment
{
    public string type{ get; set; }
    public int price;
    public int cost;
    public string description;
    public Condiment(string type,int price,int cost,string description)
    {
        this.type = type;

    this.price = price;
        this.cost = cost;
        this.description = description;
    }
    public string gettype(string type) 
    { 
        return type; 
    }
    public void getprice(string type)
    {
        if(type=="Milk")
        {
            Console.WriteLine("The price is 200");
        }
        if (type == "WhiteSugar")
        {
            Console.WriteLine("The price is 100");
        }
        if (type == "WhippedCream")
        {
            Console.WriteLine("The price is 2000");
        }
    }
    public void CalculateCost(string type)
    {
        if (type == "Milk")
        {
            Console.WriteLine("The price is 1200");
        }
        if (type == "WhiteSugar")
        {
            Console.WriteLine("The price is 1100");
        }
        if (type == "WhippedCream")
        {
            Console.WriteLine("The price is 3000");
        }

    }
    public string getdescription(string descrition)
    {
        return description;
    }
}
