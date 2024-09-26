using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App_Design_Pattern_SWE_4502_Lab_01
{
    public class Rider
    {
        public int id;
        public string name;
        public string location;
        public int rating;
        public string type;
        public Rider(int id, string name, string location, int rating, string type)
        {
            this.id = id;
            this.location = location;
            this.name = name;
            this.rating = rating;
            this.type = type;
        }
        public string requestride(string type)
        {
            if (type == "Carpool")
                Console.WriteLine("Rider is requesting for Carpool ride");
            if (type == "Luxury Ride")
            {
                Console.WriteLine("Rider is requesting for Luxury Ride");
            }
            return type;
        }
        public int ratedriver(int id)
        {
            if (id == 1)
            {
                Console.WriteLine("Customer is requesting for First class driver");
            }
            if (id == 2)
            {
                Console.WriteLine("Customer is requesting for Second class driver");
            }
            if (id == 3)
            {
                Console.WriteLine("Customer is requesting for Third class driver");
                    }
            return id;
        }
        public int makepayment(int id)
        {
            if (id == 1)
            {
                Console.WriteLine("First Class driver rate is 1500");

            }
            if (id == 2)
            {
                Console.WriteLine("Second Class driver rate is 1000");
            }
            if (id == 3)
            {
                Console.WriteLine("Third Class driver rate is 500");
            }
            return id;
        }
    }
}
