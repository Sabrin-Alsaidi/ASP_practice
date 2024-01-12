using System;
using Day4Repo.DAL.Model;
using Microsoft.EntityFrameworkCore;

namespace Day4Repo.DAL.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<Department> departments { get; set; }
        public DbSet<Employee> employees { get; set; }

    }
}

