using System;
using CodeAcademy.BLL.Interfaces;
using CodeAcademy.DAL.Context;
using CodeAcademy.DAL.Models;

namespace CodeAcademy.BLL.Reposatory
{
    public class DepartmentReposatory : GernericReposatory<Department>, IDepartmentReposatory
    {
		//private readonly ApplicationDbContext _context;
        public DepartmentReposatory(ApplicationDbContext context) : base (context)
		{
		}
	}
}

