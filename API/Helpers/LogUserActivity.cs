using API.Extensions;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc.Filters;

namespace API.Helpers
{
  public class LogUserActivity : IAsyncActionFilter
  {
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
      var resultContext = await next();

      if (!resultContext.HttpContext.User.Identity.IsAuthenticated) return;
      // above line is to check if user is authenticated so the action can execute.

      var username = resultContext.HttpContext.User.GetUsername(); //getting username for the logged in user
      var repo = resultContext.HttpContext.RequestServices.GetRequiredService<IUserRepository>(); //getting access to the repository for additions
      var user = await repo.GetUserByUsernameAsync(username);
      user.LastActive = DateTime.UtcNow;
      await repo.SaveAllAsync();

    }
  }
}