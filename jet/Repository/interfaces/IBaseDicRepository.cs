using jet.Bean;
using jet.Bean.BaseDic;

namespace jet.Repository.interfaces
{
    public interface IBaseDicRepository
    {
        void SaveItem(BaseDic baseDic);

        void DeleteItemById(string id);

        void UpdateItem(BaseDic baseDic);

        BaseDicVo GetBaseDic(string id);

        List<BaseDicVo> GetBaseDicList(BaseDicDto item);
        PageInfo<BaseDicVo> SearchBaseDic(PageSearch<BaseDicDto> item);
     
    }
}
