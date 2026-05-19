using System.Linq.Expressions;

namespace IQHealthPortal.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        //  Get
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        T GetById(int id);
        Task<T> GetByIdAsync(int id);

        //  Find
        T Find(Expression<Func<T, bool>> criteria, string[] includes = null);
        Task<T> FindAsync(Expression<Func<T, bool>> criteria, string[] includes = null);

        IEnumerable<T> FindAll(Expression<Func<T, bool>> criteria, string[] includes = null);
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>>? criteria = null, string[]? includes = null);

        //  Add
        T Add(T entity);
        Task<T> AddAsync(T entity);

        // ✏ Update
        T Update(T entity);

        //  Delete
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);

        //  Count
        int Count();
        int Count(Expression<Func<T, bool>> criteria);
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> criteria);
    }
}