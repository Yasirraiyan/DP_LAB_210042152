 public class Coffee
 {
     public string Type { get; set; } 

     
     public List<Bevarage> Beverages { get; set; } = new List<Bevarage>();
     public List<Condiment> Condiments { get; set; } = new List<Condiment>();
     public int price;
     public Coffee(string Type, int price)
     {
         this.Type = Type;
         this.price = price;
     }

     
     public void AddBeverage(Bevarage beverage)
     {
         Beverages.Add(beverage);
     }

     
     public void AddCondiment(Condiment condiment)
     {
         Condiments.Add(condiment);
     }

     
     public double GetTotalCost()
     {
         double total = 0;

         
         foreach (var beverage in Beverages)
         {
             total += beverage.price;
         }

         
         foreach (var condiment in Condiments)
         {
             total += condiment.price;
         }

         return total;
     }
     public void CalculatePrice(string Type)
     {
         if (Type =="Espresso")
         {
             Console.WriteLine("The price is 500");
         }
         if(Type =="Latte")
         {
             Console.WriteLine("The price is 1000");
         }
         if(Type =="Capacino")
         {
             Console.WriteLine("The price is 1500");
         }
     }
 }
