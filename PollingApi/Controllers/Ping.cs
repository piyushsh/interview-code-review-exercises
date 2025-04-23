using Microsoft.AspNetCore.Mvc;

namespace PollingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DateTime.Now);
        }
    }
}
