using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Sharing_App_Design_Pattern_SWE_4502_Lab_01
{
    public class NotificationService
    {
        string Notification;
        public NotificationService(string Notification)
        {
            this.Notification = Notification;
        }
        public string sendNotification(string Notification)
        {
            if (Notification == "true")
            {
                Console.WriteLine("Notification Sent");
            }
            else
            {
                Console.WriteLine("Notification not sent");
            }
            return Notification;

        }
    }
}
