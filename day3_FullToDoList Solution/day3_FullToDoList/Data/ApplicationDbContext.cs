using System;
using day3_FullToDoList.Models;
using Microsoft.EntityFrameworkCore;

namespace day3_FullToDoList.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<ToDoList>().Property(w => w.isFinished).HasDefaultValue(false);
		}

		public DbSet<ToDoList> todoLists { set; get; }
	}
}

