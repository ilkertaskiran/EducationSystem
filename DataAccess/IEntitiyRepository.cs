using System.Linq.Expressions;

namespace DataAccess
{
    public interface IEntitiyRepository<T>
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);

    }
}
