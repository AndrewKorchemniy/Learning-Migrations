using Microsoft.EntityFrameworkCore;
using MigrationsDemo;

using var db = new BlogContext();
//db.Database.Migrate();

if (!db.Posts.Any())
{
    Console.WriteLine("Adding sample data...");
    db.AddRange(
        new Post { Title = "Intro to Migrations" },
        new Post { Title = "Migrations in Team Environments" },
        new Post { Title = "Advanced Migrations"});
    db.SaveChanges();
}

Console.WriteLine("Posts:");
foreach (var post in db.Posts)
{
    Console.WriteLine($"    {post.Title}");
}