using API.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace API.SignalR
{
  [Authorize]
  public class PresenceHub : Hub
  {
    private readonly PresenceTracker _tracker;

    public PresenceHub(PresenceTracker tracker)
    {
      _tracker = tracker;

    }
    public override async Task OnConnectedAsync()
    {
      await _tracker.UserConnected(Context.User.GetUsername(), Context.ConnectionId);
      await Clients.Others.SendAsync("UserisOnline", Context.User.GetUsername());
      //this others represents everyone else but the client that is connecting(online)

      var currentUsers = await _tracker.GetOnlineUsers();
      await Clients.All.SendAsync("GetOnlineUsers", currentUsers);
    }

    public override async Task OnDisconnectedAsync(Exception exception)
    {
      await _tracker.UserDisconnected(Context.User.GetUsername(), Context.ConnectionId);
      await Clients.Others.SendAsync("UserIsOffline", Context.User.GetUsername());

      var currentUsers = await _tracker.GetOnlineUsers();
      await Clients.All.SendAsync("GetOnlineUsers", currentUsers);

      await base.OnDisconnectedAsync(exception);
    }
  }
}