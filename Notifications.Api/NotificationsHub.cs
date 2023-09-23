using Microsoft.AspNetCore.SignalR;

namespace Notifications.Api
{
    public class NotificationsHub: Hub<INotificationClient>
    {
        public override async Task OnConnectedAsync()
        {
            await Clients
                .Client(Context.ConnectionId)
                .RecieveNotification(
                    $"Thank you connecting {Context.User?.Identity?.Name}"
                );

            await base.OnConnectedAsync();
        }
    }
}
