using jet.Bean.dto;
using jet.Bean.model;
using jet.Bean.vo;

namespace jet.Repository.interfaces
{
    public interface IBaseDicRepository
    {
        void SaveItem(BaseDic baseDic);

        void DeleteItemById(string id);

        void UpdateItem(BaseDic baseDic);
        List<BaseDicVo> GetBaseDicList(BaseDicDto item);
    }
}
