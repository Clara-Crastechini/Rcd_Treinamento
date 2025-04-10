﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rcd_treinamento.Contexts;

#nullable disable

namespace rcd_treinamento.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20250403192926_Db_Rdc")]
    partial class Db_Rdc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("rcd_treinamento.Domains.Personagem", b =>
                {
                    b.Property<Guid>("PersonagemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Habilidade")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("NomePersonagem")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("PersonagemId");

                    b.ToTable("Personagem");
                });

            modelBuilder.Entity("rcd_treinamento.Domains.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.Property<Guid>("PersonagemId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UsuarioId");

                    b.HasIndex("PersonagemId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("rcd_treinamento.Domains.Usuario", b =>
                {
                    b.HasOne("rcd_treinamento.Domains.Personagem", "Personagem")
                        .WithMany()
                        .HasForeignKey("PersonagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Personagem");
                });
#pragma warning restore 612, 618
        }
    }
}
