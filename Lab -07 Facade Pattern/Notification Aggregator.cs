 public class NotificatiionAggregator
{
 private readonly List<ISocialMediaNotification> _notifications = new List<ISocialMediaNotification>();
 public NotificatiionAggregator()
 {  _notifications.Add(new TwitterNotification()); 
     _notifications.Add(new FacebookNotification());  
 } 
 public void ShowAllNotifications() 
 { 
     foreach (var platform in _notifications) 
     { 
         var notifications = platform.GetNotifications(); 
         foreach (var notification in notifications) 
         { 
             Console.WriteLine(notification); 
         } 
     } 
 } 
 public void MarkAsRead(string platformType, string notificationId) 
 { 
     var platform = _notifications.Find(p => p.GetType().Name.StartsWith(platformType)); 
     platform?.MarkAsRead(notificationId); 
 } 
 public void MarkAsUnread(string platformType, string notificationId) 
 { 
     var platform = _notifications.Find(p => p.GetType().Name.StartsWith(platformType)); 
     platform?.MarkAsUnread(notificationId); 
 } 
 public void DeleteNotification(string platformType, string notificationId) 
 { 
     var platform = _notifications.Find(p => p.GetType().Name.StartsWith(platformType)); 
     platform?.DeleteNotification(notificationId); 
 }
 }
