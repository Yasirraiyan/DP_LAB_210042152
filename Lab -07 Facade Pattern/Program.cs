 class Program
{
    public static void Main(string[] args)
    {
        var aggregator = new NotificatiionAggregator();
         aggregator.ShowAllNotifications(); 
        aggregator.MarkAsRead("Twitter", "1"); 
        aggregator.MarkAsUnread("Facebook", "2"); 
        aggregator.DeleteNotification("Twitter", "1");
    }
}
