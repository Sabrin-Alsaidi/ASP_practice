using System;
using Day4Repo.BLL.interfaces;
using Day4Repo.DAL.Context;
using Day4Repo.DAL.Model;

namespace Day4Repo.BLL.Reposatory
{
	public class DepartmentReposatory : IDepartmentReposatory
    {
        private readonly ApplicationDbContext _contect;

        public DepartmentReposatory(ApplicationDbContext context)
        {
            _contect = context;
        }

        public int Create(Department dep)
        {
            _contect.departments.Add(dep);
            return _contect.SaveChanges();
        }
        public int Delete(Department dep)
        {
            _contect.departments.Remove(dep);
            return _contect.SaveChanges();
        }
        public Department Get(int id) =>
            _contect.departments.Find(id);

        public IEnumerable<Department> GetAll() =>
            _contect.departments.ToList();

        public int Update(Department dep)
        {
            _contect.departments.Update(dep);
            return _contect.SaveChanges();
        }

    }
}

