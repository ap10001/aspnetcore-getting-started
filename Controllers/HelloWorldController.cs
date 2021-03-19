using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace helloworld.Controllers
{
    [ApiController]
    [Route("")]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            const string message = "你好，世界！";
            return message;
        }
    }
}
