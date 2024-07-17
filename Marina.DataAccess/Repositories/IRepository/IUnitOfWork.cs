using System;
using System.Threading.Tasks;

namespace Marina.DataAccess.Repositories.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IDockRepository Dock { get; }
        Task SaveAsync();
    }
}
