using Microsoft.AspNetCore.Mvc;
using PollingApi.Model;
using Repository;

namespace PollingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PollController : ControllerBase
    {
        private readonly ILogger<PollController> _logger;
        private InMemoryDb<Poll> _repository;

        public PollController(ILogger<PollController> logger)
        {
            _logger = logger;
            _repository = new InMemoryDb<Poll>();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Poll>> Get()
        {
            return Ok("Implement this endpoint");
        }

        [Route("{id}")]
        [HttpGet]
        public ActionResult<Poll> Get([FromRoute] int id)
        {
            return Ok("Implement this endpoint");
        }

        [HttpPost]
        public ActionResult<Poll> Post([FromBody] Poll p)
        {
            return Ok("Implement this endpoint");
        }

        [Route("{id}/polloption/{pollOptionId}/vote")]
        [HttpGet]
        public ActionResult Post([FromRoute] int id, [FromRoute] int pollOptionId)
        {
            return Ok("Implement this endpoint");
        }
    }
}
