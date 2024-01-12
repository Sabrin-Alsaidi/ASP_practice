using System;
using Day4Repo.DAL.Model;

namespace Day4Repo.BLL.interfaces
{
	public interface  IEmployeeReposatory
	{
		
            IEnumerable<Employee> GetAll();
            Employee Get(int id);
            int Create(Employee emp);
            int Update(Employee emp);
            int Delete(Employee emp);
        
	}
}

