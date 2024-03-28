using Lab4Web.Services.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLinqController : ControllerBase
    {
        private readonly ILinqService _linqService;

        public TestLinqController(ILinqService linqService)
        {
            _linqService = linqService;
        }

        [HttpGet("test-1")]
        public string Get1(int a)
        {
            return _linqService.Test1(a);
        }
        [HttpGet("test-2")]
        public List<Car> Get2(string brand)
        {
            return _linqService.Test2(brand);
        }

        [HttpGet("test-3")]
        public List<string> Get3()
        {
            return _linqService.Test3();
        }

        [HttpGet("test-4")]
        public List<Object> Get4()
        {
            return _linqService.Test4();
        }

    }
}
