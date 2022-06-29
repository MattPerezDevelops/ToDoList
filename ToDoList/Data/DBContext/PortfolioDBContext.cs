using Microsoft.EntityFrameworkCore;
using ToDoList.Data.Models;
namespace ToDoList.Data.DBContext;

internal sealed class PortfolioDBContext : DbContext
{
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) => dbContextOptionsBuilder.UseSqlite(connectionString:"Data Source=ToDoList.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Post[] postToSeed = new Post[6];
        for(int i = 1; i <= 6; i++)
        {
            postToSeed[i - 1] = new Post
            {
                PostId = i, Title = $"Post {i}", Content = $"Content {i}"
            };
        }
        modelBuilder.Entity<Post>().HasData(postToSeed);
    }

}
