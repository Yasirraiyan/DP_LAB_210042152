public class Cofeeshop
{
    public List<Bevarage> Bevarages;
    public string type;
    public Cofeeshop(Bevarage bevarage, string type)
    {
        this.type = type;
        Bevarages = new List<Bevarage>();
    }
    public void Add(Bevarage bevarage)
    {
        Bevarages.Add(bevarage);
    }
    public string gettype(string type)
    {
        return type;
    }
}
