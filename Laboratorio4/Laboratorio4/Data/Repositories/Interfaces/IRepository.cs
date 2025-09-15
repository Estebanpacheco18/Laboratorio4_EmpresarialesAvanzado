namespace Laboratorio4.Data.Repositories.Interfaces;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T GetById(object id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
}
