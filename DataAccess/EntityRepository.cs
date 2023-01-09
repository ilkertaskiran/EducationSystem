using DataLayer;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess
{
    public class EfEntitiyRepositoryBase<TEntitiy, TContext> : IEntitiyRepository<TEntitiy>
        //This class is not used for now
         where TEntitiy : class, new()
         where TContext : AppDbContext, new()
    {
        public void Add(TEntitiy entitiy)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entitiy);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntitiy entitiy)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entitiy);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntitiy Get(Expression<Func<TEntitiy, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntitiy>().SingleOrDefault(filter);
            }
        }

        public List<TEntitiy> GetList(Expression<Func<TEntitiy, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ?
                    context.Set<TEntitiy>().ToList() :
                    context.Set<TEntitiy>().Where(filter).ToList();
            }
        }

        public void Update(TEntitiy entitiy)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entitiy);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}