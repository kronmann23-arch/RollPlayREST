namespace RollPlayREST.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        T Add(T o);
        T Update(int id, T o);
        T Remove(int id);
    }
}
