using jet.Bean.model;

namespace jet.Repository.interfaces
{
    public interface IBaseDicRepository
    {
        void SaveBaseDic(BaseDic baseDic);

        void DeleteById(string id);

        void UpdateBaseDic(BaseDic baseDic);
    }
}
