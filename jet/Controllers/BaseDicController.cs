using jet.Bean.dto;
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


        [HttpPost("saveBaseDic")]
        public void SaveBaseDic([FromBody] BaseDicDto item)
        {
            _baseDicService.SaveBaseDic(item);
        }

        [HttpDelete("deleteById")]
        public void DeleteById(string id)
        {
            _baseDicService.DeleteById(id);
        }

        [HttpPost("updateBaseDic")]
        public void UpdateBaseDic([FromBody] BaseDicDto item)
        {
            _baseDicService.UpdateBaseDic(item);
        }


 

    }
}
