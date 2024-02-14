using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PingController : ControllerBase
  {
    [HttpGet]
    public ActionResult<string> Get()
    {
      return "pong";
    }
  }
}