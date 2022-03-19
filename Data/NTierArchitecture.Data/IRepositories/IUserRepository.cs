using NTierArchitecture.Data.Common;
using NTierArchitecture.Data.Model;

namespace NTierArchitecture.Data.IRepositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<string> GetFirstNameAndLastName(Guid ID);
    }
}
