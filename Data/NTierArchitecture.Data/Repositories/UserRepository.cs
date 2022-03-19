using Dapper;
using NTierArchitecture.Data.Common;
using NTierArchitecture.Data.IRepositories;
using NTierArchitecture.Data.Model;
using System.Data;

namespace NTierArchitecture.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(
            IDbConnection dbConnection,
            IDbTransaction dbTransaction
        ) : base(dbConnection, dbTransaction)
        {

        }

        public async Task<bool> Add(User entity)
        {
            try
            {
                //Transaction ile örnek. commit edilmese geçmez
                string sql = " INSERT INTO [User] (ID ,Username ,Firstname ,Lastname ,Email ,Active ,CreatedBy ,CreatedOn ,UpdatedBy ,UpdatedOn ,DeletedOn) VALUES (@ID ,@Username ,@Firstname ,@Lastname ,@Email ,@Active ,@CreatedBy ,@CreatedOn ,@UpdatedBy ,@UpdatedOn ,@DeletedOn)";
                var res = await _dbConnection.ExecuteAsync(sql, entity, transaction: _dbTransaction) > 0;
                return res;
            }
            catch
            {
                _dbTransaction.Rollback();
                throw;
            }
        }

        public async Task<bool> Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Upsert(User entity)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetById(Guid ID)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var sql = "SELECT * FROM [User]"; //TODO test için *
            return await _dbConnection.QueryAsync<User>(sql,null,_dbTransaction);
        }

        public async Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Any()
        {
            throw new NotImplementedException();
        }

        public async Task<string> GetFirstNameAndLastName(Guid ID)
        {
            throw new NotImplementedException();
        }
    }
}
