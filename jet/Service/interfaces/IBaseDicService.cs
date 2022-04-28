using jet.Bean.dto;
using jet.Bean.model;

namespace jet.Service.interfaces
{
    public interface IBaseDicService
    {
        void SaveBaseDic(BaseDicDto item);

        void DeleteById(string id);
        void UpdateBaseDic(BaseDicDto item);
    }
}
