using System;
using FullToDoWebsite.Models;
using Microsoft.EntityFrameworkCore;

namespace FullToDoWebsite.Data
{
	public class ApplicationDbContext:DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ToDoTasks>().Property(w => w.Task_Status).HasDefaultValue(false);
        }

        public DbSet<ToDoTasks> todoTask { set; get; }
    }

}

