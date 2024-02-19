
namespace WebApplication1
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        private readonly CalcService _calcService;

        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        [HttpGet("add")]
        public ActionResult<int> Add(int a, int b)
        {
            return _calcService.Add(a, b);
        }

        [HttpGet("subtract")]
        public ActionResult<int> Subtract(int a, int b)
        {
            return _calcService.Subtract(a, b);
        }

        [HttpGet("multiply")]
        public ActionResult<int> Multiply(int a, int b)
        {
            return _calcService.Multiply(a, b);
        }

        [HttpGet("divide")]
        public ActionResult<int> Divide(int a, int b)
        {
            return _calcService.Divide(a, b);
        }
    }

}
