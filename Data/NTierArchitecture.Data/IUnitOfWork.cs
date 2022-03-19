using NTierArchitecture.Data.IRepositories;

namespace NTierArchitecture.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IMuhitRepository MuhitRepository { get; }

        void Commit();
        void Rollback();
    }
}
