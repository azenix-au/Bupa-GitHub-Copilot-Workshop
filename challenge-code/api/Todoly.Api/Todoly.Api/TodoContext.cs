using Microsoft.EntityFrameworkCore;

namespace Todoly.Api
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem
                {
                    Id = 1,
                    Name = "Install Copilot",
                    IsComplete = false
                },
                new TodoItem
                {
                    Id = 2,
                    Name = "Learn Copilot",
                    IsComplete = false
                },
                new TodoItem
                {
                    Id = 3,
                    Name = "Build Amazing Apps",
                    IsComplete = false
                });
        }

    }
}
