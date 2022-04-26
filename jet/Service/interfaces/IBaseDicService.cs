using jet.Bean.dto;
using jet.Bean.model;

namespace jet.Service.interfaces
{
    public interface IBaseDicService
    {
        void SaveBaseDic(BaseDicDto item);


        BaseDic GetById(string id);
    }
}
