using jet.Service.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace jet.Controllers
{

    [Route("jet/baseDic")]
    [ApiController]
    public class BaseDicController : ControllerBase
    {

        private readonly IBaseDicService _baseDicService;

        public BaseDicController(IBaseDicService baseDicService)
        {
            _baseDicService = baseDicService;
        }


        [HttpGet("get")]
        public IActionResult Get()
        {
            string id = "1122";
            var result = _baseDicService.Get(id);
            return Ok(result);
        }

        [HttpGet]
        public string Index() => "Welecome to .NetCore";


        [HttpGet("num")]
        public int Num() => 10;

    }
}
