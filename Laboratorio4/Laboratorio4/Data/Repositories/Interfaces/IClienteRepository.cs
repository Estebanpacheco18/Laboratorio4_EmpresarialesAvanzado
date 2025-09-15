using Laboratorio4.Models;

namespace Laboratorio4.Data.Repositories.Interfaces;


public interface IClienteRepository
{
    clientes? GetById(int id);
    IEnumerable<clientes> GetAll();
    void Add(clientes clientes);
    void Update(clientes clientes);
    void Delete(clientes clientes);
}
