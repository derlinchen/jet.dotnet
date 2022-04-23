using Microsoft.AspNetCore.Mvc;

namespace jet.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class BaseDicController : ControllerBase
    {
        [HttpGet]
        public string Index() => "Welecome to .NetCore";


        [HttpGet("num")]
        public int Num() => 10;

    }
}
