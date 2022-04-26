using jet.Bean.model;

namespace jet.Repository.interfaces
{
    public interface IBaseDicRepository
    {
        void SaveBaseDic(BaseDic baseDic);


        BaseDic GetById(string id);
    }
}
