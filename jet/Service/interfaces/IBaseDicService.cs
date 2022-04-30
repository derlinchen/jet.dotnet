using jet.Bean;
using jet.Bean.BaseDic;

namespace jet.Service.interfaces
{
    public interface IBaseDicService
    {
        void SaveBaseDic(BaseDicDto item);

        void DeleteBaseDic(string id);

        void UpdateBaseDic(BaseDicDto item);

        List<BaseDicVo> GetBaseDicList(BaseDicDto item);
        PageInfo<BaseDicVo> SearchBaseDic(PageSearch<BaseDicDto> item);
    }
}
