public class FacebookNotification : ISocialMediaNotification
{
    public List<string> GetNotifications()
    {

        return new List<string> { "Facebook Notification 1", "Facebook Notification 2" };
    }
    public void MarkAsRead(string notificationId) 
    { 
        Console.WriteLine($"Facebook Notification {notificationId} marked as read."); 
    }
    
    public void MarkAsUnread(string notificationId) 
    {
        Console.WriteLine($"Facebook Notification {notificationId} marked as unread.");
    }
    public void DeleteNotification(string notificationId) 
    { 
        Console.WriteLine($"Facebook Notification {notificationId} deleted."); 
    }

}
