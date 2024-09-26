
using Ride_Sharing_App_Design_Pattern_SWE_4502_Lab_01;
using System;

class Program
{
    public static void Main(string[] args)
    {

        Admin admin = new Admin(1, "Alice", "true");
        admin.managedriver(admin.role);   
        admin.managerider(1);             
        admin.viewTripHistory();          
        admin.handledispute(1);
        Rider r1 = new Rider(1, "A", "Dhaka", 1, "Carpool");
    Rider r2 = new Rider(1, "A", "Chitaggong", 2, "LuxuryRide");
    Console.WriteLine(r1.requestride("Carpool"));

Console.WriteLine( r2.requestride("Luxury Ride"));
Console.WriteLine(r1.ratedriver(1));
Console.WriteLine(r1.makepayment(1));
Driver d1 = new Driver(1, "A", "Cng", "Motijheel", 1, true);
    Console.WriteLine(d1.acceptride(d1.availability));
Console.WriteLine(d1.raterider(1));

      Ridetype ridetype = new Ridetype(3);
    Console.WriteLine(ridetype.farecalculation(3));
      Payment p1 = new Payment(4);
    Console.WriteLine(p1.processpayment(4));
      NotificationService ns = new NotificationService("true");
    Console.WriteLine(ns.sendNotification("true"));
      Admin a1 = new Admin(1, "B", "true");
    Console.WriteLine(a1.managedriver("true"));
      
Console.WriteLine(a1.managerider(1));
Console.WriteLine(a1.handledispute(1));
    }
}

