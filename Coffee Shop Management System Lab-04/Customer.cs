public class Customer
{
    public List<Condiment> Condiments=new List<Condiment>();
    public Customer() 
    { 
        Condiments=new List<Condiment>();
    }
    public void AddCondiment(Condiment condiment)
    {
        Condiments.Add(condiment);
    }
}
