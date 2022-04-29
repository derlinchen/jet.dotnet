using jet.Bean.dto;
using jet.Bean.model;
using jet.Bean.vo;
using jet.Config;
using jet.Repository.interfaces;
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

        public void SaveItem(BaseDic baseDic)
        {
            _dbContext.Set<BaseDic>().Add(baseDic);
            _dbContext.SaveChanges();
        }

        public void DeleteItemById(string id)
        {
            _dbContext.Database.ExecuteSqlRaw("delete from base_dic where id = ?", id);
        }

        public void UpdateItem(BaseDic baseDic)
        {
            BaseDic baseDicItem = _dbContext.Set<BaseDic>().FromSqlRaw<BaseDic>("select * from base_dic").Where(x => x.Id == baseDic.Id).First();
            if (baseDicItem != null)
            {
                baseDicItem.Name = baseDic.Name;
                _dbContext.SaveChanges();
            }

        }

        public List<BaseDicVo> GetBaseDicList(BaseDicDto item)
        {
            var queryable = _dbContext.Set<BaseDicVo>().FromSqlRaw<BaseDicVo>("select * from base_dic");
            if(item.Id != null && item.Id !="")
            {
                queryable = queryable.Where(x => x.Id == item.Id);
            }

            if(item.Name != null && item.Name != "")
            {
                queryable = queryable.Where(x => x.Name == item.Name);
            }
            List<BaseDicVo> result = queryable.ToList();
            return result;
        }
    }
}
