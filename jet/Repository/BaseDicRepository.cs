using jet.Bean.model;
using jet.Config;
using jet.Repository.interfaces;
using jet.Utils;
using Microsoft.EntityFrameworkCore;

namespace jet.Repository
{
    public class BaseDicRepository : IBaseDicRepository
    {
        private readonly EFCoreContext _dbContext;

        public BaseDicRepository(EFCoreContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveBaseDic(BaseDic baseDic)
        {
            _dbContext.Set<BaseDic>().Add(baseDic);
            _dbContext.SaveChanges();
        }

        public void DeleteById(string id)
        {
            _dbContext.Database.ExecuteSqlRaw("delete from base_dic where id = ?", id);
        }

        public void UpdateBaseDic(BaseDic baseDic)
        {
            BaseDic baseDicItem = _dbContext.Set<BaseDic>().FromSqlRaw("select * from base_dic where id = ?", baseDic.Id).First();
            if (baseDicItem != null)
            {
                baseDicItem.Name = baseDic.Name;
                _dbContext.SaveChanges();
            }

        }
    }
}
