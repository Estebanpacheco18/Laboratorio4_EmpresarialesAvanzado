using Laboratorio4.Data.Repositories.Interfaces;
using Laboratorio4.Models;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio4.Data.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly DbContext _context;

    public ClienteRepository(DbContext context)
    {
        _context = context;
    }

    public clientes? GetById(int id)
    {
        return _context.Set<clientes>().Find(id);
    }

    public IEnumerable<clientes> GetAll()
    {
        return _context.Set<clientes>().ToList();
    }

    public void Add(clientes clientes)
    {
        _context.Set<clientes>().Add(clientes);
    }

    public void Update(clientes clientes)
    {
        _context.Set<clientes>().Update(clientes);
    }

    public void Delete(clientes clientes)
    {
        _context.Set<clientes>().Remove(clientes);
    }
}

