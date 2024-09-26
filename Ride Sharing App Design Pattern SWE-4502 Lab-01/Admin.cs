using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ride_Sharing_App_Design_Pattern_SWE_4502_Lab_01
{
    public class Admin
    {
        public int id;
        public string name;
        public string role;

        public Admin(int id, string name, string role)
        {
            this.id = id;
            this.name = name;
            this.role = role;
        }
        public string managedriver(string role)
        {
            if (role == "true")
            {
                Console.WriteLine("Driver Managed");
            }
            else
            {
                Console.WriteLine("Driver not managed");
            }
            return role;
        }
        public int managerider(int id)
        {
            if (id == 1)
            {
                Console.WriteLine("First class rider managed");
            }
            if (id == 2)
            {
                Console.WriteLine("Second class rider");
            }
            else
            {
                Console.WriteLine("rider is bad");
            }
            return id;
        }
        public string viewTripHistory()
        {
            return $"History for{name}";
    

    }
        public int handledispute(int id)
        {
            if (id == 1)
            {
                Console.WriteLine("First class driver is handled");

            }
            else if (id == 2)
            {
                Console.WriteLine("Second class driver is handled");
            }
            else
            {
                Console.WriteLine("Third class driver is handled");
            }
            return id;
        }
    }
}
