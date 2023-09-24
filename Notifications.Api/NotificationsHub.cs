using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Notifications.Api
{
    [Authorize]
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
