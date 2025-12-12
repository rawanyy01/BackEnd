using System;
using System.Collections.Generic;
using DevConnect.Models;
using Microsoft.EntityFrameworkCore;

namespace DevConnect.Contexts;

public partial class DevConnectContext : DbContext
{
    public DevConnectContext()
    {
    }

    public DevConnectContext(DbContextOptions<DevConnectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbComentario> TbComentario { get; set; }

    public virtual DbSet<TbCurtida> TbCurtida { get; set; }

    public virtual DbSet<TbPublicacao> TbPublicacao { get; set; }

    public virtual DbSet<TbUsuario> TbUsuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=DevCon_Windows");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TbComentario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_comen__3213E83F1778AD5E");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbComentario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_coment__id_us__5629CD9C");
        });

        modelBuilder.Entity<TbCurtida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_curti__3213E83F0812D825");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbCurtida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__tb_curtid__id_us__534D60F1");
        });

        modelBuilder.Entity<TbPublicacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_publi__3213E83FFB86532B");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbPublicacao).HasConstraintName("FK__tb_public__id_us__5070F446");
        });

        modelBuilder.Entity<TbUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tb_usuar__3213E83FF33545CA");

            entity.HasMany(d => d.IdUsuarioSeguidor).WithMany(p => p.IdUsuarioSeguindo)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidores",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__5EBF139D"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguindo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__5DCAEF64"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguindo", "IdUsuarioSeguidor").HasName("PK__tb_segui__F4D90E20D19BC158");
                        j.ToTable("tb_seguidores");
                        j.IndexerProperty<int>("IdUsuarioSeguindo").HasColumnName("id_usuario_seguindo");
                        j.IndexerProperty<int>("IdUsuarioSeguidor").HasColumnName("id_usuario_seguidor");
                    });

            entity.HasMany(d => d.IdUsuarioSeguindo).WithMany(p => p.IdUsuarioSeguidor)
                .UsingEntity<Dictionary<string, object>>(
                    "TbSeguidores",
                    r => r.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguindo")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__5DCAEF64"),
                    l => l.HasOne<TbUsuario>().WithMany()
                        .HasForeignKey("IdUsuarioSeguidor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__tb_seguid__id_us__5EBF139D"),
                    j =>
                    {
                        j.HasKey("IdUsuarioSeguindo", "IdUsuarioSeguidor").HasName("PK__tb_segui__F4D90E20D19BC158");
                        j.ToTable("tb_seguidores");
                        j.IndexerProperty<int>("IdUsuarioSeguindo").HasColumnName("id_usuario_seguindo");
                        j.IndexerProperty<int>("IdUsuarioSeguidor").HasColumnName("id_usuario_seguidor");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
