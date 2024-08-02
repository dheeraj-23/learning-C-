namespace Practice
{
    public delegate void NotificationEventHandler(string message);
    internal class Notifier
    {
        public event NotificationEventHandler Notify;

        public void SendNotification(string message)
        {
            Notify?.Invoke(message);
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine($"Received notification: {message}");
        }
    }


}
