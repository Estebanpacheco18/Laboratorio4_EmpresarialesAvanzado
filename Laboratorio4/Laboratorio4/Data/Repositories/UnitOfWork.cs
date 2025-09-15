using Laboratorio4.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio4.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly DbContext _context;
    public IClienteRepository Clientes { get; }

    public UnitOfWork(DbContext context, IClienteRepository clienteRepository)
    {
        _context = context;
        Clientes = clienteRepository;
    }

    public IClienteRepository ClienteRepository { get; }

    public int SaveChanges()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}