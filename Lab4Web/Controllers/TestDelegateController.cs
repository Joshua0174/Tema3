using Lab4Web.Services.Delegate;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestDelegateController : ControllerBase
    {
        private readonly IDelegateService _delegateService;

        public TestDelegateController(IDelegateService delegateService)
        {
            _delegateService = delegateService;
        }

        [HttpGet("test-1")]
        public float Test1(string operationName, int x, int y)
        {
            var callback0 = _delegateService.Add;
            var callback1=_delegateService.Substract;
            var callback = operationName == "Adunare" ? callback0 : (operationName == "Scadere" ? callback1: null); //ar trebui abordat cumva cazul in care nu a fost aleasa o operatie valida
            return _delegateService.DoOperation(callback , x, y); 
        }

        [HttpGet("test-2")]
        public float Test2(int x,int y)
        {   
            var callback0 = _delegateService.Divide;
            var callback1=_delegateService.Multiply;
            var callback = (int x,int y) => x > y ? callback0(x,y) : callback1(x,y);
            return _delegateService.DoOperation(callback,x,y);
        }
        [HttpGet("test-3")]
        public float Test3(int x, int y)  //trece prin toate metodele insa pastreaza doar rezultatul inmultirii
        {
            Func<int, int, float> callback1 = _delegateService.Multiply; // înmulțire
            Func<int, int, float> callback2 = _delegateService.Add; // adunare
            Func<int, int, float> callback = (a, b) => callback2(a, b) + callback1(a, b); // înmulțire urmată de adunare
            return _delegateService.DoOperation(callback, x, y);
        }
    }
}
