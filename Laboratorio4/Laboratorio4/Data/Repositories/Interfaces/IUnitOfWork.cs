namespace Laboratorio4.Data.Repositories.Interfaces;

public interface IUnitOfWork: IDisposable
{
    IClienteRepository Clientes { get; }
    int SaveChanges();
}