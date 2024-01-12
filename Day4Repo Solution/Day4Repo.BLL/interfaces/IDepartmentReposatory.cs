using System;
using Day4Repo.DAL.Model;


namespace Day4Repo.BLL.interfaces
{
	public interface IDepartmentReposatory
	{
        IEnumerable<Department> GetAll();
		Department Get(int id);
		int Create(Department dep);
		int Update(Department dep);
		int Delete(Department dep);


    }
}

