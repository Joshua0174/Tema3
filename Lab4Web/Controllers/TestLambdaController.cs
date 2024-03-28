using Lab4Web.Services.Lambda;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLambdaController : ControllerBase
    {
        private readonly ILambdaService _lambdaService;

        public TestLambdaController(ILambdaService lambdaService)
        {
            _lambdaService = lambdaService;
        }

        [HttpGet("test-1")]
        public string Method()
        {
            return _lambdaService.Test1();
        }

        [HttpGet("test-2")]
        public string Test2(string value)
        {
            return _lambdaService.Test2(value);
        }

        [HttpGet("test-3")]
        public double Test3(int a, int b)
        {
            return _lambdaService.Test3(a,b);
        }
        [HttpGet("test-4")]
        public double Test4(double a, string b)
        {
            return _lambdaService.Test4(a, b);
        }
        [HttpGet("test-5")]
        public double Test5(double a)
        {
            return _lambdaService.Test5(a);
        }

        [HttpGet("test-6")]
        public string Test6(Tuple<int,int>tuple)
        {
            return _lambdaService.Test6(tuple);
        }
        [HttpGet("test-7")]
        public Task<string> Test7(string sir, int y)
        {
            var res= _lambdaService.asyncMethod(sir, y);
            return res;
        }

    }
}
