using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MyBlog.EntityLayer.Abstract;

namespace MyBlog.DataAccessLayer.EntityFramework;

public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
where TEntity : class, IEntity,new()
where TContext : DbContext
{
    private readonly TContext _context;

    public EfEntityRepositoryBase(TContext context)
    {
        _context = context;
    }

    public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    {
        
           return filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
        
    }

    public TEntity Get(Expression<Func<TEntity, bool>> filter)
    {
       
            return _context.Set<TEntity>().FirstOrDefault(filter);
        
    }

    public void Add(TEntity entity)
    {
       
            var addedEntity = _context.Entry(entity);
            addedEntity.State = EntityState.Added;
            _context.SaveChanges();
        
    }

    public void Update(TEntity entity)
    {
       
           var updatedEntity = _context.Entry(entity);
           updatedEntity.State = EntityState.Modified;
           _context.SaveChanges();
        
    }

    public void Delete(TEntity entity)
    {
        
            var deletedEntity = _context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            _context.SaveChanges();
        
    }
}