using System;
using CodeAcademy.BLL.Interfaces;
using CodeAcademy.DAL.Context;

namespace CodeAcademy.BLL.Reposatory
{
    public class GernericReposatory<T> : IGenericReposatory<T> where T : class
    {
		private readonly ApplicationDbContext _context;
        public GernericReposatory(ApplicationDbContext context)
		{
			_context = context;
		}
        //Get or View
        public T Get(int Id) => _context.Set<T>().Find(Id);

        public IEnumerable<T> GetAll() => _context.Set<T>().ToList();

        //Add Naew
        public int Create(T item)
        {
            _context.Set<T>().Add(item);
            return _context.SaveChanges();
        }

        //Delete data
        public int Delete(T item)
        {
            _context.Set<T>().Remove(item);
            return _context.SaveChanges();
        }

        //Update data
        public int Update(T item)
        {
            _context.Set<T>().Update(item);
            return _context.SaveChanges();
        }

        
    }
}

