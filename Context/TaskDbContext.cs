using Microsoft.EntityFrameworkCore;
using System.Data;
using TaskApi.Models;

namespace TaskApi.Context
{
    public class TaskDbContext:DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options)
        : base(options) { }

        public DbSet<Models.Task> Tasks { get; set; }

    }
}
