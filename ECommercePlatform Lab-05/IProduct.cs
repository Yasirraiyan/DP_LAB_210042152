 public interface IProduct
 {
     string name { get; }
     string description { get; }
     double price { get; }
     double getprice();
     void DisplayDetails();
     string getname();
     double discount { get; }

 }
