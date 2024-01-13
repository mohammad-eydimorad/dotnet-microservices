using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
  [Route("api/commands/[controller]")]
  [ApiController]
  public class PlatformsController : ControllerBase
  {
    public PlatformsController()
    {

    }

    [HttpPost]
    public ActionResult TestInvoundConnection()
    {
      Console.WriteLine("---> Inbound POST # Command Service");
      
      return Ok("Inbound test of from Platforms Controller");
    }
  }
}