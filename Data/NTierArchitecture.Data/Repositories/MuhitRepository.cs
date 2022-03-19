using Dapper;
using NTierArchitecture.Data.Common;
using NTierArchitecture.Data.IRepositories;
using NTierArchitecture.Data.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchitecture.Data.Repositories
{
    public class MuhitRepository : Repository<Muhit>, IMuhitRepository
    {
        public MuhitRepository(
            IDbConnection dbConnection,
            IDbTransaction dbTransaction
        ) : base(dbConnection, dbTransaction)
        {

        }

        public async Task<bool> Add(Muhit entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Guid ID)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Muhit entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(Muhit entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Upsert(Muhit entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Muhit> GetById(Guid ID)
        {
            var sql = "SELECT * FROM Users WHERE ID=@ID"; //transaction örnek
            return await _dbConnection.QueryFirstAsync<Muhit>(sql, new { ID = ID }, transaction: _dbTransaction);
        }

        public async Task<IEnumerable<Muhit>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Any()
        {
            throw new NotImplementedException();
        }
    }
}
