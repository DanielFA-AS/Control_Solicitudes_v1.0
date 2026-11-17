using System;
using System.Collections.Generic;
using API_ControlSolicitudes.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_ControlSolicitudes.Data;

public partial class ControlSolicitudesContext : DbContext
{
    public ControlSolicitudesContext(DbContextOptions<ControlSolicitudesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccionesTrazabilidad> AccionesTrazabilidads { get; set; }

    public virtual DbSet<Desarrolladore> Desarrolladores { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<HistorialTrazabilidad> HistorialTrazabilidads { get; set; }

    public virtual DbSet<Prioridad> Prioridads { get; set; }

    public virtual DbSet<Solicitud> Solicituds { get; set; }

    public virtual DbSet<TipoSolicitud> TipoSolicituds { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccionesTrazabilidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ACCIONES__3214EC07470CA744");

            entity.ToTable("ACCIONES_TRAZABILIDAD");

            entity.Property(e => e.Accion).HasMaxLength(25);
            entity.Property(e => e.Detalle).HasMaxLength(50);
        });

        modelBuilder.Entity<Desarrolladore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DESARROL__3214EC0789A301ED");

            entity.ToTable("DESARROLLADORES");

            entity.Property(e => e.Amaterno)
                .HasMaxLength(50)
                .HasColumnName("AMaterno");
            entity.Property(e => e.Apaterno)
                .HasMaxLength(50)
                .HasColumnName("APaterno");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ESTADO__3214EC07D846C81D");

            entity.ToTable("ESTADO");

            entity.Property(e => e.Estado1)
                .HasMaxLength(25)
                .HasColumnName("Estado");
        });

        modelBuilder.Entity<HistorialTrazabilidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HISTORIA__3214EC07410FD1E5");

            entity.ToTable("HISTORIAL_TRAZABILIDAD");

            entity.Property(e => e.ComResolu).HasMaxLength(100);
            entity.Property(e => e.Detalle).HasMaxLength(250);
            entity.Property(e => e.FechaHora).HasMaxLength(50);
            entity.Property(e => e.FkAccion).HasColumnName("FK_Accion");
            entity.Property(e => e.FkSolicitud).HasColumnName("FK_Solicitud");

            entity.HasOne(d => d.FkAccionNavigation).WithMany(p => p.HistorialTrazabilidads)
                .HasForeignKey(d => d.FkAccion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HISTORIAL__FK_Ac__5FB337D6");

            entity.HasOne(d => d.FkSolicitudNavigation).WithMany(p => p.HistorialTrazabilidads)
                .HasForeignKey(d => d.FkSolicitud)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HISTORIAL__ComRe__5EBF139D");
        });

        modelBuilder.Entity<Prioridad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PRIORIDA__3214EC0789C6C9B8");

            entity.ToTable("PRIORIDAD");

            entity.Property(e => e.Prioridad1)
                .HasMaxLength(15)
                .HasColumnName("Prioridad");
        });

        modelBuilder.Entity<Solicitud>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SOLICITU__3214EC075E99BA3B");

            entity.ToTable("SOLICITUD");

            entity.Property(e => e.Descripcion).HasMaxLength(150);
            entity.Property(e => e.FkEstado).HasColumnName("FK_Estado");
            entity.Property(e => e.FkPrioridad).HasColumnName("FK_Prioridad");
            entity.Property(e => e.FkResponsable).HasColumnName("FK_Responsable");
            entity.Property(e => e.FkSolicitante).HasColumnName("FK_Solicitante");
            entity.Property(e => e.FkTipo).HasColumnName("FK_Tipo");

            entity.HasOne(d => d.FkEstadoNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.FkEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SOLICITUD__FK_Es__5BE2A6F2");

            entity.HasOne(d => d.FkPrioridadNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.FkPrioridad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SOLICITUD__FK_Pr__59FA5E80");

            entity.HasOne(d => d.FkResponsableNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.FkResponsable)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SOLICITUD__FK_Re__5AEE82B9");

            entity.HasOne(d => d.FkSolicitanteNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.FkSolicitante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SOLICITUD__FK_Es__5812160E");

            entity.HasOne(d => d.FkTipoNavigation).WithMany(p => p.Solicituds)
                .HasForeignKey(d => d.FkTipo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__SOLICITUD__FK_Ti__59063A47");
        });

        modelBuilder.Entity<TipoSolicitud>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TIPO_SOL__3214EC07CFF6F747");

            entity.ToTable("TIPO_SOLICITUD");

            entity.Property(e => e.Clave).HasMaxLength(100);
            entity.Property(e => e.Detalle).HasMaxLength(50);
            entity.Property(e => e.Tipo).HasMaxLength(25);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__USUARIOS__3214EC071771C27D");

            entity.ToTable("USUARIOS");

            entity.Property(e => e.Amaterno)
                .HasMaxLength(50)
                .HasColumnName("AMaterno");
            entity.Property(e => e.Apaterno)
                .HasMaxLength(50)
                .HasColumnName("APaterno");
            entity.Property(e => e.Correo).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .HasColumnName("Usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
