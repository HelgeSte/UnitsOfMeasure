using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UoM2023_ConsoleApp.Models;

namespace UoM2023_ConsoleApp.Data;

public partial class Uom2023Context : DbContext
{
    public Uom2023Context()
    {
    }

    public Uom2023Context(DbContextOptions<Uom2023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<UnitsOfMeasure> UnitsOfMeasures { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=uom2023;Integrated Security=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
