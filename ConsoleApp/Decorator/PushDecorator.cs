public class PushDecorator : NotificationDecorator
{
    public PushDecorator(INotification notification) : base(notification) { }

    public override void Send(string message)
    {
        base.Send(message);
        SendPush(message);
    }

    private void SendPush(string message)
    {
        Console.WriteLine($"Enviando push notification: {message}");
        // Lógica real de envio de push
    }
}