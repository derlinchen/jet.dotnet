using jet.Bean;
using jet.Bean.BaseDic;
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

        [HttpDelete("deleteBaseDic")]
        public void DeleteBaseDic(string id)
        {
            _baseDicService.DeleteBaseDic(id);
        }

        [HttpPost("updateBaseDic")]
        public void UpdateBaseDic([FromBody] BaseDicDto item)
        {
            _baseDicService.UpdateBaseDic(item);
        }

        [HttpGet("getBaseDic")]
        public BaseDicVo GetBaseDic(string id)
        {
            return _baseDicService.GetBaseDic(id);
        }

        [HttpPost("getBaseDicList")]
        public List<BaseDicVo> GetBaseDicList([FromBody] BaseDicDto item)
        {
            return _baseDicService.GetBaseDicList(item);
        }

        [HttpPost("searchBaseDic")]
        public PageInfo<BaseDicVo> SearchBaseDic([FromBody] PageSearch<BaseDicDto> item)
        {
            return _baseDicService.SearchBaseDic(item);
        }
 



    }
}
