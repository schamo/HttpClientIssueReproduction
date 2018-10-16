using Microsoft.AspNetCore.Mvc;

namespace HttpClientIssue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IMyService _myService;

        public DataController(IMyService myService)
        {
            _myService = myService;
        }

        // GET api/data
        [HttpGet]
        public ActionResult<string> Get()
        {
            return _myService.GetData();
        }
    }
}
