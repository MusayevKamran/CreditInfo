using CreditInfo.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using CreditInfo.Persistance.Repository.Interfaces;

namespace CreditInfo.Persistance.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly CreditInfoDbContext _db;
    private readonly DbSet<TEntity> _dbSet;

    public Repository(CreditInfoDbContext context)
    {
        _db = context;
        _dbSet = _db.Set<TEntity>();
    }
    public virtual void Add(TEntity obj)
    {
        _dbSet.Add(obj);
    }

    public virtual IQueryable<TEntity> GetAll()
    {
        return _dbSet;
    }

    public virtual TEntity GetById(Guid id)
    {
        return _dbSet.Find(id);
    }

    public virtual void Remove(Guid id)
    {
        _dbSet.Remove(_dbSet.Find(id));
    }

    public virtual void Update(TEntity obj)
    {
        _dbSet.Update(obj);
    }

    public int SaveChanges()
    {
        return _db.SaveChanges();
    }

    public void Dispose()
    {
        _db.Dispose();
        GC.SuppressFinalize(this);
    }
}