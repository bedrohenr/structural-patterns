public class EmailDecorator : NotificationDecorator
{
    public EmailDecorator(INotification notification) : base(notification) { }

    public override void Send(string message)
    {
        base.Send(message); // Chama o decorador anterior na cadeia
        SendEmail(message);
    }

    private void SendEmail(string message)
    {
        Console.WriteLine($"Enviando email: {message}");
        // Lógica real de envio de email
    }
}