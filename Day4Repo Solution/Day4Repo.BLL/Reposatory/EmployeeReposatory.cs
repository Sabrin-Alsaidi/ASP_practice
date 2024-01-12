using System;
using Day4Repo.BLL.interfaces;
using Day4Repo.DAL.Context;
using Day4Repo.DAL.Model;

namespace Day4Repo.BLL.Reposatory
{
	public class EmployeeReposatory
	{
		private readonly ApplicationDbContext _contaxt;
		public EmployeeReposatory(ApplicationDbContext contaxt)
		{
			_contaxt = contaxt;
		}
        public int Create(Employee emp)
        {
            _contaxt.employees.Add(emp);
            return _contaxt.SaveChanges();
        }
        public int Delete(Employee emp)
        {
            _contaxt.employees.Remove(emp);
            return _contaxt.SaveChanges();
        }
        public Employee Get(int id) =>
            _contaxt.employees.Find(id);

        public IEnumerable<Employee> GetAll() =>
            _contaxt.employees.ToList();

        public int Update(Employee emp)
        {
            _contaxt.employees.Update(emp);
            return _contaxt.SaveChanges();
        }
    }
}

