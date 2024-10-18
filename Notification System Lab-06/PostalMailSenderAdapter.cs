public class PostalMailSenderAdapter : INotificationSender
{
    private readonly ThirdPartyPostalMailService _postalMailService = new ThirdPartyPostalMailService();

    public void Send(string recipient, string message)
    {
        string recipientAddress = GetAddressFromRecipient(recipient);
        string recipientName = GetNameFromRecipient(recipient);
        _postalMailService.SendPostalMail(recipientAddress, recipientName, message);
    }

    private string GetAddressFromRecipient(string recipient)
    {
       
        return "123 Main St.";
    }

    private string GetNameFromRecipient(string recipient)
    {
        
        return "John Doe";
    }
}
