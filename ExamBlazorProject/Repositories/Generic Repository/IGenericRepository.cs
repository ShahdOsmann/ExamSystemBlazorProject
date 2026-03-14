// Repositories/IGenericRepository.cs
using System.Linq.Expressions;

namespace ExamBlazorProject
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
    }
}