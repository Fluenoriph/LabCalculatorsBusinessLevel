using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


class ApplicationContext : DbContext
{        
    public ApplicationContext() : base() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .SetBasePath("C:\\Users\\Mahabhara\\source\\repos\\LabCalculatorsBusinessLevel\\LabCalculatorsBusinessLevel")
                        .Build();

        optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
    }
}
