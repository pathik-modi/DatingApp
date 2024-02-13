using API.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace API.SignalR
{
  [Authorize]
  public class PresenceHub : Hub
  {
    public override async Task OnConnectedAsync()
    {
      await Clients.Others.SendAsync("UserisOnline", Context.User.GetUsername());
      //this others represents everyone else but the client that is connecting(online)
    }

    public override async Task OnDisconnectedAsync(Exception exception)
    {
      await Clients.Others.SendAsync("UserIsOffline", Context.User.GetUsername());
      await base.OnDisconnectedAsync(exception);
    }
  }
}