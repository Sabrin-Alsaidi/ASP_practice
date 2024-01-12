using System;
using Day2.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2.Data
{
	public class ApplicationDbContext:DbContext 
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}

		public DbSet<TODOList> TODOList { get; set; }

    }
}

