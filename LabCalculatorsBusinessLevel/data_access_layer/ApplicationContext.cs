using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


class ApplicationContext : DbContext
{
    public DbSet<AirDustCalcParametersData> AirDustCalcParameters { get; set; } = null!;
    public DbSet<AirDustCalcResultsData> AirDustCalcResults { get; set; } = null!;
    public DbSet<DateOfCalculationData> DateOfCalculation { get; set; } = null!;
    public DbSet<RegisterData> Register { get; set; } = null!;

    public ApplicationContext() : base()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
                        .AddJsonFile("settings.json")
                        .SetBasePath("C:\\Users\\Mahabhara\\source\\repos\\LabCalculatorsBusinessLevel\\LabCalculatorsBusinessLevel")
                        .Build();

        optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
    }
}
