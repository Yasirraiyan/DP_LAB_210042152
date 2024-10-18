  class Program
{
    public static void Main(string[] args)
    {
        INotificationSender emailSender = new EmailSender();
        INotificationSender smsSender = new SmsSender();
        INotificationSender postalMailSender = new PostalMailSenderAdapter();

        NotificationService emailNotificationService = new NotificationService(emailSender);
        NotificationService smsNotificationService = new NotificationService(smsSender);
        NotificationService postalMailNotificationService = new NotificationService(postalMailSender);

        emailNotificationService.Notify("email@example.com", "Hello via Email!");
        smsNotificationService.Notify("1234567890", "Hello via SMS!");
        postalMailNotificationService.Notify("postal@example.com", "Hello via Postal Mail!");
    }
}
