namespace NTierArchitecture.Service.IServices.Base
{
    public interface IService<T>
    {
        Task<bool> Add(T entityDTO);
        Task<bool> Delete(Guid ID);
        Task<bool> Delete(T entityDTO);
        Task<bool> Update(T entityDTO);
        Task<bool> Upsert(T entityDTO);
        Task<T> GetById(Guid ID);
        Task<IEnumerable<T>> GetAll();
        Task<int> Count();
        Task<bool> Any();
    }
}
