 public class TwitterNotification : ISocialMediaNotification
 {
     public List<string> GetNotifications()
     {
          return new List<string> 
          { 
              "Twitter Notification 1", 
              "Twitter Notification 2" 
          }; 
     } 
     public void MarkAsRead(string notificationId) 
     { 
         Console.WriteLine($"Twitter Notification {notificationId} marked as read."); 
     } 
     public void MarkAsUnread(string notificationId) 
     { 
         Console.WriteLine($"Twitter Notification {notificationId} marked as unread."); 
     } 
     public void DeleteNotification(string notificationId) 
     { 
         Console.WriteLine($"Twitter Notification {notificationId} deleted."); 
     }
     }
