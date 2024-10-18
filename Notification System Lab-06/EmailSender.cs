 public class EmailSender : INotificationSender
{
    void Send(string message, string reciepient)
    {
        Console.WriteLine($"Email sent to {recipient}: {message}");
    }
}
