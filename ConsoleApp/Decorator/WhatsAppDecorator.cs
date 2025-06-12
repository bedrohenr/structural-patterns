public class WhatsAppDecorator : NotificationDecorator
{
    public WhatsAppDecorator(INotification notification) : base(notification) { }

    public override void Send(string message)
    {
        base.Send(message);
        SendWhatsApp(message);
    }

    private void SendWhatsApp(string message)
    {
        Console.WriteLine($"Enviando WhatsApp: {message}");
    }
}
