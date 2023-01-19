using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DL;

public partial class EignacioAeroMexicoContext : DbContext
{
    public EignacioAeroMexicoContext()
    {
    }

    public EignacioAeroMexicoContext(DbContextOptions<EignacioAeroMexicoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pasajero> Pasajeros { get; set; }

    public virtual DbSet<Vuelo> Vuelos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-4F295B7J; Database= EIgnacioAeroMexico; Trusted_Connection=True; TrustServerCertificate=True; User ID=sa; Password=pass@word1;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pasajero>(entity =>
        {
            entity.HasKey(e => e.IdPasajero).HasName("PK__Pasajero__78E232CB12860A01");

            entity.Property(e => e.ApellidoMarteno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoParteno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vuelo>(entity =>
        {
            entity.HasKey(e => e.IdVuelo).HasName("PK__Vuelo__2176172693AB2D0C");

            entity.ToTable("Vuelo");

            entity.Property(e => e.Destino)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.FechaSalida).HasColumnType("datetime");
            entity.Property(e => e.NumeroVuelo)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Origen)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
