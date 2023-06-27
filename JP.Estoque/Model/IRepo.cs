namespace JP.Estoque.Model
{
    internal interface IRepo<T>
    {
        Task<T> Get(int id);
        Task Delete(int id);
        Task Insert(T item);
        Task Update(T item);
        Task<IEnumerable<T>> GetAll();
    }
}
