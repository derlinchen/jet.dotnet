using jet.Bean.model;
using jet.Repository.interfaces;
using jet.Service.interfaces;

namespace jet.Service
{
    public class BaseDicService : IBaseDicService
    {
        private IBaseDicRepository _baseDicRepository;

        public BaseDicService(IBaseDicRepository baseDicRepository)
        {
            _baseDicRepository = baseDicRepository;
        }

        public BaseDic Get(string id)
        {
            return _baseDicRepository.GetById(id);
        }
    }
}
