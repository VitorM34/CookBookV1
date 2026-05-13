using Microsoft.EntityFrameworkCore;

namespace MyRecipeBook.Infrastructure.DataAccess;

public class MyRecipeBookDbContext : DbContext
{
    public MyRecipeBookDbContext(DbContextOptions options) : base(options) { }
    
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder);
    
    }

