using LibraryRepo.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryRepo.Repo
{

    public class RepoBase<T> where T : class
    {
        ElectricStoreDBContext _context;
        DbSet<T> _dbSet;

        public RepoBase()
        {
            _context = new ElectricStoreDBContext();
            _dbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public bool Create(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Remove(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(T entity)
        {
            try
            {
                var tracker = _context.Attach(entity);
                tracker.State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



    }
}