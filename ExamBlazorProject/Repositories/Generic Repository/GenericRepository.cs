
using ExamBlazorProject.Data;
using Microsoft.EntityFrameworkCore;

namespace ExamBlazorProject
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll() => _dbSet;

        public T GetById(int id) => _dbSet.Find(id);

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            Save();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            Save();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}