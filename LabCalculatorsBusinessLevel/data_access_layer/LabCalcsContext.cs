using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


partial class LabCalcsContext : DbContext
{
    public LabCalcsContext() { }

    public LabCalcsContext(DbContextOptions<LabCalcsContext> options)
        : base(options) { }

    public virtual DbSet<CalculatorType> CalculatorTypes { get; set; }

    public virtual DbSet<FormulaTypeCalculatorData> FormulaTypeCalculatorData { get; set; }

    public virtual DbSet<NoiseCalculatorData> NoiseCalculatorData { get; set; }

    public virtual DbSet<RegistrationTime> RegistrationTime { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json")
                        .SetBasePath("C:\\Users\\Grand Riph\\source\\repos\\Fluenoriph\\LabCalculatorsBusinessLevel\\LabCalculatorsBusinessLevel") 
                        .Build(); // >>>> Directory.GetCurrentDirectory() <<<<

        optionsBuilder.UseNpgsql(config.GetConnectionString("DefaultConnection"));
    }
       
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CalculatorType>(entity =>
        {
            entity.HasKey(e => e.CalcTypeId).HasName("calculator_type_pkey");

            entity.ToTable("calculator_type");

            entity.HasIndex(e => e.CalcTypeName, "calculator_type_calc_type_name_key").IsUnique();

            entity.Property(e => e.CalcTypeId)
                .ValueGeneratedNever()
                .HasColumnName("calc_type_id");
            entity.Property(e => e.CalcTypeName).HasColumnName("calc_type_name");
        });

        modelBuilder.Entity<FormulaTypeCalculatorData>(entity =>
        {
            entity.HasKey(e => e.DataId).HasName("formula_type_calculator_data_pkey");

            entity.ToTable("formula_type_calculator_data");
                        
            entity.Property(e => e.DataId).HasColumnName("data_id");
            entity.Property(e => e.DataId).ValueGeneratedOnAdd();
            entity.Property(e => e.Parameter).HasColumnName("parameter");
            entity.Property(e => e.RegTimeId).HasColumnName("reg_time_id");
            entity.Property(e => e.Result).HasColumnName("result");

            entity.HasOne(d => d.RegTime).WithMany(p => p.FormulaTypeCalculatorData)
                .HasForeignKey(d => d.RegTimeId)
                .HasConstraintName("formula_type_calculator_data_reg_time_id_fkey");
        });

        modelBuilder.Entity<NoiseCalculatorData>(entity =>
        {
            entity.HasKey(e => e.DataId).HasName("noise_calculator_data_pkey");

            entity.ToTable("noise_calculator_data");
                       
            entity.Property(e => e.DataId).HasColumnName("data_id");
            entity.Property(e => e.DataId).ValueGeneratedOnAdd();

            entity.Property(e => e.BackgroundLevel).HasColumnName("background_level");
            entity.Property(e => e.Delta).HasColumnName("delta");
            entity.Property(e => e.RegTimeId).HasColumnName("reg_time_id");
            entity.Property(e => e.Result).HasColumnName("result");
            entity.Property(e => e.SourceLevel).HasColumnName("source_level");

            entity.HasOne(d => d.RegTime).WithMany(p => p.NoiseCalculatorData)
                .HasForeignKey(d => d.RegTimeId)
                .HasConstraintName("noise_calculator_data_reg_time_id_fkey");
        });

        modelBuilder.Entity<RegistrationTime>(entity =>
        {
            entity.HasKey(e => e.RegTimeId).HasName("registration_time_pkey");

            entity.ToTable("registration_time");

            entity.Property(e => e.RegTimeId).HasColumnName("reg_time_id");
            entity.Property(e => e.RegTimeId).ValueGeneratedOnAdd();

            entity.Property(e => e.CalcTypeId).HasColumnName("calc_type_id");
            entity.Property(e => e.RegTimeValue)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("reg_time_value");

            entity.HasOne(d => d.CalcType).WithMany(p => p.RegistrationTime)
                .HasForeignKey(d => d.CalcTypeId)
                .HasConstraintName("registration_time_calc_type_id_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
