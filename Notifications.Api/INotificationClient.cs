namespace Notifications.Api
{
    public interface INotificationClient
    {
        Task RecieveNotification(string message);
    }
}
