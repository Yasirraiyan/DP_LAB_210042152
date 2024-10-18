public class SMSSender: INotificationSender
{
    void Send(string message, string reciepient)
    {
        Console.WriteLine($"SMS sent to {recipient}: {message}");
    }
}
