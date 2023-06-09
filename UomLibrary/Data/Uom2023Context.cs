﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UomLibrary.Models;

namespace UomLibrary.Data;

public partial class Uom2023Context : DbContext
{
    public Uom2023Context()
    {
    }

    public Uom2023Context(DbContextOptions<Uom2023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<ConversionToBaseUnit> ConversionToBaseUnits { get; set; }

    public virtual DbSet<QuantityType> QuantityTypes { get; set; }

    public virtual DbSet<SameUnit> SameUnits { get; set; }

    public virtual DbSet<UnitsOfMeasure> UnitsOfMeasures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-LN5BF6J;Initial Catalog=uom2023;Integrated Security=True;Encrypt=False;Trust Server Certificate=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ConversionToBaseUnit>(entity =>
        {
            entity.HasKey(e => e.ConversionId).HasName("PK__Conversi__A7A07E733CB461AD");

            entity.HasOne(d => d.Uom).WithMany(p => p.ConversionToBaseUnits).HasConstraintName("FK__Conversio__UomId__4CA06362");
        });

        modelBuilder.Entity<QuantityType>(entity =>
        {
            entity.HasKey(e => e.QuantityTypeId).HasName("PK__Quantity__9E4B23C9B3D91387");

            entity.HasOne(d => d.Uom).WithMany(p => p.QuantityTypes).HasConstraintName("FK__QuantityT__UomId__440B1D61");
        });

        modelBuilder.Entity<SameUnit>(entity =>
        {
            entity.HasKey(e => e.SameUnitId).HasName("PK__SameUnit__FF4EA036F6597BF1");

            entity.HasOne(d => d.Uom).WithMany(p => p.SameUnits).HasConstraintName("FK__SameUnit__UomId__46E78A0C");
        });

        modelBuilder.Entity<UnitsOfMeasure>(entity =>
        {
            entity.HasKey(e => e.UomId).HasName("PK__UnitsOfM__F6F8D47E6D60223C");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
