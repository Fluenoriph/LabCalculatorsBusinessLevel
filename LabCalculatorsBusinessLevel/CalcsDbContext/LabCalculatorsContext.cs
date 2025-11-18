using System;
using System.Collections.Generic;
using LabCalculatorsBusinessLevel.Models;
using Microsoft.EntityFrameworkCore;

namespace LabCalculatorsBusinessLevel.CalcsDbContext;

public partial class LabCalculatorsContext : DbContext
{
    public LabCalculatorsContext()
    {
    }

    public LabCalculatorsContext(DbContextOptions<LabCalculatorsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Airparameter> Airparameters { get; set; }

    public virtual DbSet<Airresult> Airresults { get; set; }

    public virtual DbSet<Dateofcalculation> Dateofcalculations { get; set; }

    public virtual DbSet<Register> Registers { get; set; }

    public virtual DbSet<Typeofcalculator> Typeofcalculators { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=LabCalculators;Username=postgres;Password=robov");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airparameter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("airparameters");

            entity.HasIndex(e => e.Registerid, "airparameters_registerid_key").IsUnique();

            entity.Property(e => e.Massafter).HasColumnName("massafter");
            entity.Property(e => e.Massbefore).HasColumnName("massbefore");
            entity.Property(e => e.Parametersid)
                .HasDefaultValueSql("nextval('airparameters_id_seq'::regclass)")
                .HasColumnName("parametersid");
            entity.Property(e => e.Pressure).HasColumnName("pressure");
            entity.Property(e => e.Registerid).HasColumnName("registerid");
            entity.Property(e => e.Temperature).HasColumnName("temperature");
            entity.Property(e => e.Volume).HasColumnName("volume");

            entity.HasOne(d => d.Register).WithOne()
                .HasForeignKey<Airparameter>(d => d.Registerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("airparameters_registerid_fkey");
        });

        modelBuilder.Entity<Airresult>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("airresults");

            entity.HasIndex(e => e.Registerid, "airresults_registerid_key").IsUnique();

            entity.Property(e => e.Concentrate).HasColumnName("concentrate");
            entity.Property(e => e.Fault).HasColumnName("fault");
            entity.Property(e => e.Registerid).HasColumnName("registerid");
            entity.Property(e => e.Resultsid)
                .HasDefaultValueSql("nextval('airresults_id_seq'::regclass)")
                .HasColumnName("resultsid");

            entity.HasOne(d => d.Register).WithOne()
                .HasForeignKey<Airresult>(d => d.Registerid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("airresults_registerid_fkey");
        });

        modelBuilder.Entity<Dateofcalculation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dateofcalculation_pkey");

            entity.ToTable("dateofcalculation");

            entity.HasIndex(e => e.Value, "dateofcalculation_value_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<Register>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("register_pkey");

            entity.ToTable("register");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Calcdate).HasColumnName("calcdate");
            entity.Property(e => e.Calctype).HasColumnName("calctype");

            entity.HasOne(d => d.CalcdateNavigation).WithMany(p => p.Registers)
                .HasForeignKey(d => d.Calcdate)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("register_calcdate_fkey");

            entity.HasOne(d => d.CalctypeNavigation).WithMany(p => p.Registers)
                .HasForeignKey(d => d.Calctype)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("register_calctype_fkey");
        });

        modelBuilder.Entity<Typeofcalculator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("typeofcalculator_pkey");

            entity.ToTable("typeofcalculator");

            entity.HasIndex(e => e.Value, "typeofcalculator_value_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Value)
                .HasMaxLength(30)
                .HasColumnName("value");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
