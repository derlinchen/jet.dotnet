using jet.Bean.dto;
using jet.Bean.vo;

namespace jet.Service.interfaces
{
    public interface IBaseDicService
    {
        void SaveBaseDic(BaseDicDto item);

        void DeleteBaseDic(string id);

        void UpdateBaseDic(BaseDicDto item);

        List<BaseDicVo> GetBaseDicList(BaseDicDto item);
    }
}
