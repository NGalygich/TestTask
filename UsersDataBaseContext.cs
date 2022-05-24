using Microsoft.EntityFrameworkCore;
namespace TestTask;

public partial class UsersDataBaseContext : DbContext
{
    public UsersDataBaseContext()
    {
    }

    public UsersDataBaseContext(DbContextOptions<UsersDataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=UsersDataBase.db");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}