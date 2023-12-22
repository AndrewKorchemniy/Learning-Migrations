using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MigrationsDemo;

class BlogContext : DbContext
{
    public DbSet<Post> Posts { get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
}

class Post
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
}