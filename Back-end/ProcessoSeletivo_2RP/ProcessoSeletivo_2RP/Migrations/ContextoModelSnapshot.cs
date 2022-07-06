﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProcessoSeletivo_2RP.Models;

#nullable disable

namespace ProcessoSeletivo_2RP.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("senai_gufi_webAPI.Domains.TipoUsuario", b =>
                {
                    b.Property<int>("IdTipoUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTipoUsuario"), 1L, 1);

                    b.Property<string>("TituloTipoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTipoUsuario");

                    b.ToTable("TipoUsuarios");
                });

            modelBuilder.Entity("senai_gufi_webAPI.Domains.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IdTipoUsuario")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdTipoUsuarioNavigationIdTipoUsuario")
                        .HasColumnType("int");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("status")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.HasKey("IdUsuario");

                    b.HasIndex("IdTipoUsuarioNavigationIdTipoUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("senai_gufi_webAPI.Domains.Usuario", b =>
                {
                    b.HasOne("senai_gufi_webAPI.Domains.TipoUsuario", "IdTipoUsuarioNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdTipoUsuarioNavigationIdTipoUsuario");

                    b.Navigation("IdTipoUsuarioNavigation");
                });

            modelBuilder.Entity("senai_gufi_webAPI.Domains.TipoUsuario", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
