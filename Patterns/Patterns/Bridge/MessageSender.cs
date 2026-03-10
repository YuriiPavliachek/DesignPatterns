namespace Patterns.Bridge
{
    public interface IMessageSender
    {
        void SendMessage(string message);
    }
    public class EmailSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("Email: " + message);
        }
    }
    public class SmsSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("SMS: " + message);
        }
    }
}
