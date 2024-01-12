using System;
using CodeAcademy.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademy.DAL.Context
{
	public class ApplicationDbContext :DbContext 
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
		{

		}
		public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }

    }
}

