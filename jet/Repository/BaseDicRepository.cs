using jet.Bean.model;
using jet.Config;
using jet.Repository.interfaces;

namespace jet.Repository
{
    public class BaseDicRepository : Repository<BaseDic>, IBaseDicRepository
    {
        private readonly EFCoreContext _dbContext;

        public BaseDicRepository(EFCoreContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
