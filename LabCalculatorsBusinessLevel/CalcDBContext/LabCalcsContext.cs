using LabCalculatorsBusinessLevel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LabCalculatorsBusinessLevel.CalcDBContext;


public partial class LabCalcsContext : DbContext
{
    public LabCalcsContext() { }

    public LabCalcsContext(DbContextOptions<LabCalcsContext> options)
        : base(options) { }

    public virtual DbSet<AirParameters> Airparameters { get; set; }

    public virtual DbSet<AirResults> Airresults { get; set; }

    public virtual DbSet<DateOfCalculation> Dateofcalculations { get; set; }

    public virtual DbSet<Register> Registers { get; set; }

    public virtual DbSet<TypeOfCalculator> Typeofcalculators { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .SetBasePath("C:\\Users\\Mahabhara\\source\\repos\\LabCalculatorsBusinessLevel\\LabCalculatorsBusinessLevel")
                        .Build();

        optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AirParameters>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("airparameters_pkey");

            entity.ToTable("airparameters");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.FilterWeightAfter).HasColumnName("filterweightafter");
            entity.Property(e => e.FilterWeightBefore).HasColumnName("filterweightbefore");
            entity.Property(e => e.Pressure).HasColumnName("pressure");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.Volume).HasColumnName("volume");
        });

        modelBuilder.Entity<AirResults>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("airresults_pkey");

            entity.ToTable("airresults");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concentrate).HasColumnName("concentrate");
            entity.Property(e => e.Fault).HasColumnName("fault");
        });

        modelBuilder.Entity<DateOfCalculation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dateofcalculation_pkey");

            entity.ToTable("dateofcalculation");

            entity.HasIndex(e => e.Value, "dateofcalculation_value_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Register>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("register_pkey");

            entity.ToTable("register");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CalcDateId).HasColumnName("calcdateid");
            entity.Property(e => e.CalcTypeId).HasColumnName("calctypeid");
            entity.Property(e => e.ParametersId).HasColumnName("parametersid");
            entity.Property(e => e.ResultsId).HasColumnName("resultsid");

            entity.HasOne(d => d.CalcDate).WithMany(p => p.Registers)
                .HasForeignKey(d => d.CalcDateId)
                .HasConstraintName("register_calcdateid_fkey");

            entity.HasOne(d => d.CalcType).WithMany(p => p.Registers)
                .HasForeignKey(d => d.CalcTypeId)
                .HasConstraintName("register_calctypeid_fkey");

            entity.HasOne(d => d.Parameters).WithMany(p => p.Registers)
                .HasForeignKey(d => d.ParametersId)
                .HasConstraintName("register_parametersid_fkey");

            entity.HasOne(d => d.Results).WithMany(p => p.Registers)
                .HasForeignKey(d => d.ResultsId)
                .HasConstraintName("register_resultsid_fkey");
        });

        modelBuilder.Entity<TypeOfCalculator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("typeofcalculator_pkey");

            entity.ToTable("typeofcalculator");

            entity.HasIndex(e => e.Name, "typeofcalculator_name_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
