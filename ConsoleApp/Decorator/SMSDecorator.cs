public class SMSDecorator : NotificationDecorator
{
    public SMSDecorator(INotification notification) : base(notification) { }

    public override void Send(string message)
    {
        base.Send(message);
        SendSMS(message);
    }

    private void SendSMS(string message)
    {
        Console.WriteLine($"Enviando SMS: {message}");
        // Lógica real de envio de SMS
    }
}