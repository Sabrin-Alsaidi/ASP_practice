using System;
using CodeAcademy.BLL.Interfaces;
using CodeAcademy.DAL.Context;
using CodeAcademy.DAL.Models;

namespace CodeAcademy.BLL.Reposatory
{
	public class EmployeeReposatory : GernericReposatory<Employee> ,IEmployeeReposatory
    {
       // private readonly ApplicationDbContext _context;
        public EmployeeReposatory(ApplicationDbContext context) : base(context)
        {
        }
       
	}
}

