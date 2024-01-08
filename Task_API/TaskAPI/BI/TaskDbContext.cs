using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskAPI.Models;

namespace TaskAPI.BI
{
    public class TaskDbContext : DbContext
    {
        //public TaskDbContext(DbContextOptions<TaskDbContext> options)
        //: base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-US4CG7QE;Database=Aswathi_TaskDB;Trusted_Connection=True;TrustServerCertificate=Yes");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
