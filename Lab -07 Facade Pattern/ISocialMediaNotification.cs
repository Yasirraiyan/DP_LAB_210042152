 public interface ISocialMediaNotification
 {
     
    List<string> GetNotifications();
     void MarkAsRead(string notificationId);
     void MarkAsUnread(string notificationId);
     void DeleteNotification(string notificationId);
 }
