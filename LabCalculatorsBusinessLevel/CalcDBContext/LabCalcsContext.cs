using LabCalculatorsBusinessLevel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LabCalculatorsBusinessLevel.CalcDBContext;


public partial class LabCalcsContext : DbContext
{
    public LabCalcsContext() { }

    public LabCalcsContext(DbContextOptions<LabCalcsContext> options)
        : base(options) { }

    public virtual DbSet<Airparameters> Airparameters { get; set; }

    public virtual DbSet<Airresults> Airresults { get; set; }

    public virtual DbSet<Dateofcalculation> Dateofcalculations { get; set; }

    public virtual DbSet<Register> Registers { get; set; }

    public virtual DbSet<Typeofcalculator> Typeofcalculators { get; set; }

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
        modelBuilder.Entity<Airparameters>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("airparameters_pkey");

            entity.ToTable("airparameters");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Massafter).HasColumnName("massafter");
            entity.Property(e => e.Massbefore).HasColumnName("massbefore");
            entity.Property(e => e.Pressure).HasColumnName("pressure");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.Volume).HasColumnName("volume");
        });

        modelBuilder.Entity<Airresults>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("airresults_pkey");

            entity.ToTable("airresults");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concentrate).HasColumnName("concentrate");
            entity.Property(e => e.Fault).HasColumnName("fault");
        });

        modelBuilder.Entity<Dateofcalculation>(entity =>
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
            entity.Property(e => e.Calcdateid).HasColumnName("calcdateid");
            entity.Property(e => e.Calctypeid).HasColumnName("calctypeid");
            entity.Property(e => e.Parametersid).HasColumnName("parametersid");
            entity.Property(e => e.Resultsid).HasColumnName("resultsid");

            entity.HasOne(d => d.Calcdate).WithMany(p => p.Registers)
                .HasForeignKey(d => d.Calcdateid)
                .HasConstraintName("register_calcdateid_fkey");

            entity.HasOne(d => d.Calctype).WithMany(p => p.Registers)
                .HasForeignKey(d => d.Calctypeid)
                .HasConstraintName("register_calctypeid_fkey");

            entity.HasOne(d => d.Parameters).WithMany(p => p.Registers)
                .HasForeignKey(d => d.Parametersid)
                .HasConstraintName("register_parametersid_fkey");

            entity.HasOne(d => d.Results).WithMany(p => p.Registers)
                .HasForeignKey(d => d.Resultsid)
                .HasConstraintName("register_resultsid_fkey");
        });

        modelBuilder.Entity<Typeofcalculator>(entity =>
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
