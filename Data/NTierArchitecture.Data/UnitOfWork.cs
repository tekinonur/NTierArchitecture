using NTierArchitecture.Data.IRepositories;
using System.Data;

namespace NTierArchitecture.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository UserRepository { get; }

        public IMuhitRepository MuhitRepository { get; }

        protected IDbTransaction _dbTransaction;

        public UnitOfWork(
            IDbTransaction dbTransaction,
            IUserRepository userRepository,
            IMuhitRepository muhitRepository
        )
        {
            _dbTransaction = dbTransaction;
            UserRepository = userRepository;
            MuhitRepository = muhitRepository;
        }

        public void Commit()
        {
            try
            {
                _dbTransaction.Commit();
            }
            catch
            {
                Rollback();
                throw;
            }
        }

        public void Rollback()
        {
            _dbTransaction.Rollback();
        }

        public void Dispose()
        {
            _dbTransaction.Connection?.Close();
            _dbTransaction.Connection?.Dispose();
            _dbTransaction.Dispose();
        }
    }
}
