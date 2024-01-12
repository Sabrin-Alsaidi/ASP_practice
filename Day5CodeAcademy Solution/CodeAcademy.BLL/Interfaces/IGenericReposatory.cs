using System;
namespace CodeAcademy.BLL.Interfaces
{
	public interface IGenericReposatory<T>
	{
		IEnumerable<T> GetAll();
		T Get(int Id);
		int Create(T item);
        int Update(T item);
        int Delete(T item);


    }
}

