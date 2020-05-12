using Microsoft.AspNetCore.Mvc;

namespace MiddlewareTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("{testTask}")]
        public ActionResult<string> Get(string testTask)
        {
            return testTask;
        }
    }

}