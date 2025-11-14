using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


class ApplicationContext : DbContext
{
    //public DbSet<User> Users { get; set; } = null!;
    public ApplicationContext() : base()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
                        .AddJsonFile("settings.json")
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .Build();

        optionsBuilder.UseSqlite(config.GetConnectionString("DefaultConnection"));
    }
}
