using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Interfaces.Repositories;
using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.PrimeiroExercicioAPIASPNetCore.Repository.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly SQLServerContext _context;
        private DbSet<T> _dbSet;

        public BaseRepository(SQLServerContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T item)
        {
            _dbSet.Add(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public T GetById(int id)
        {
            return _dbSet.FirstOrDefault(i => GetId(i) == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        private int GetId(T item)
        {
            return Convert.ToInt32(item.GetType().GetProperty("Id").GetValue(item, null));
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
