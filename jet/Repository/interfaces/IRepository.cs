using jet.Bean;
using System.Linq.Expressions;

namespace jet.Repository.interfaces
{
    public interface IRepository<T> where T : BaseBean
    {
        T GetById(string id);
        IEnumerable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
