using jet.Bean.model;

namespace jet.Repository.interfaces
{
    public interface IBaseDicRepository
    {
        BaseDic GetById(string id);
    }
}
