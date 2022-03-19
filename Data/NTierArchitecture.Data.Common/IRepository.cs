namespace NTierArchitecture.Data.Common
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Add(T entity);
        Task<bool> Delete(Guid ID);
        Task<bool> Delete(T entity);
        Task<bool> Update(T entity);
        Task<bool> Upsert(T entity);
        Task<T> GetById(Guid ID);
        Task<IEnumerable<T>> GetAll();
        Task<int> Count();
        Task<bool> Any();
    }
}
