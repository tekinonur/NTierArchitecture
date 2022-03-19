using System.Data;

namespace NTierArchitecture.Data.Common
{
    public class Repository<T> where T : class
    {
        protected IDbConnection _dbConnection;

        protected IDbTransaction _dbTransaction;

        public Repository(
            IDbConnection dbConnection,
            IDbTransaction dbTransaction
        )
        {
            _dbConnection = dbConnection;
            _dbTransaction = dbTransaction;
        }
    }
}
