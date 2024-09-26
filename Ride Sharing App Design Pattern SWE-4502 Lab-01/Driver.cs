using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App_Design_Pattern_SWE_4502_Lab_01
{
    public class Driver
    {
        public int id;
        public string name;
        public string vehicletype;
        public string location;
        public int rating;
        public bool availability;
        public Driver(int id, string name, string vehicletype, string location, int rating, bool availability)
        {
            this.id = id;
            this.name = name;
            this.vehicletype = vehicletype;
            this.location = location;
            this.rating = rating;
            this.availability = availability;

        }
        public bool acceptride(bool availability)
        {
            if (availability == true)
            {
                Console.WriteLine("Driver available");
            }

            else
            {
                Console.WriteLine("Driver not available");
            }
            
            return availability;

        }
        public int raterider(int id)
        {
            if (id == 1)
            {
                Console.WriteLine("First Class Driver");
            }
            if (id == 2)
            {
                Console.WriteLine("Second Class Driver");
            }
            if (id == 3)
            {
                Console.WriteLine("Third Class Driver");
            }
            return id;

        }
    }
    
}
