using Laboratorio4.Data.Repositories.Interfaces;

namespace Laboratorio4.Data.Repositories;

using Microsoft.EntityFrameworkCore;

using Interfaces;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly TiendaDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(TiendaDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public IEnumerable<T> GetAll() => _dbSet.ToList();

    public T? GetById(object id) => _dbSet.Find(id);

    public void Add(T entity) => _dbSet.Add(entity);

    public void Update(T entity) => _dbSet.Update(entity);

    public void Delete(T entity) => _dbSet.Remove(entity);
}

