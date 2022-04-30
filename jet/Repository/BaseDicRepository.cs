using jet.Bean;
using jet.Bean.BaseDic;
using jet.Config;
using jet.exceptions;
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

        public BaseDicVo GetBaseDic(string id)
        {
            BaseDicVo ? result = _dbContext.Set<BaseDicVo>().FromSqlRaw("select * from base_dic").SingleOrDefault(x => x.Id == id);
            return result;
        }

        public List<BaseDicVo> GetBaseDicList(BaseDicDto item)
        {
            var queryable = _dbContext.Set<BaseDicVo>().FromSqlRaw<BaseDicVo>("select * from base_dic");
            if (item.Id != null && item.Id != "")
            {
                queryable = queryable.Where(x => x.Id == item.Id);
            }

            if (item.Name != null && item.Name != "")
            {
                queryable = queryable.Where(x => x.Name == item.Name);
            }
            List<BaseDicVo> result = queryable.ToList();
            return result;
        }

        public PageInfo<BaseDicVo> SearchBaseDic(PageSearch<BaseDicDto> item)
        {
            BaseDicDto? queryCondition = item.Item;
            if (item.PageSize <= 0)
            {
                throw new JetException("请输入正确的每页条数");
            }

            if (item.PageNum <= 0)
            {
                item.PageNum = 1;
            }
            PageInfo<BaseDicVo> result = new PageInfo<BaseDicVo>();

            var countQueryable = _dbContext.Set<BaseDic>().AsQueryable();
            if (queryCondition != null)
            {
                if (queryCondition.Id != null && queryCondition.Id != "")
                {
                    countQueryable = countQueryable.Where(x => x.Id == queryCondition.Id);
                }

                if (queryCondition.Name != null && queryCondition.Name != "")
                {
                    countQueryable = countQueryable.Where(x => x.Name == queryCondition.Name);
                }
            }

            int total = countQueryable.Count();


            var resultQueryable = _dbContext.Set<BaseDicVo>().FromSqlRaw("select * from base_dic");
            if (queryCondition != null)
            {
                if (queryCondition.Id != null && queryCondition.Id != "")
                {
                    resultQueryable = resultQueryable.Where(x => x.Id == queryCondition.Id);
                }

                if (queryCondition.Name != null && queryCondition.Name != "")
                {
                    resultQueryable = resultQueryable.Where(x => x.Name == queryCondition.Name);
                }
            }
            List<BaseDicVo> lists = resultQueryable.Skip((item.PageNum - 1) * item.PageSize).Take(item.PageSize).ToList();

            result.PageNum = item.PageNum;
            result.PageSize = item.PageSize;
            result.Total = total;
            result.PageCount = DbUtils.CalcPageCount(total, item.PageSize);
            result.Lists = lists;
            return result;
        }

    }
}
