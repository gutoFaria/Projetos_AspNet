﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(QuizDbContext))]
    [Migration("20221229125548_QuizCreate")]
    partial class QuizCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebAPI.Models.Materia", b =>
                {
                    b.Property<int>("MateriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MateriaId"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MateriaId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("WebAPI.Models.Pergunta", b =>
                {
                    b.Property<int>("PerguntaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PerguntaId"));

                    b.Property<string>("DescricaoPergunta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resposta1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resposta2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resposta3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resposta4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RespostaCerta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TemaId")
                        .HasColumnType("int");

                    b.HasKey("PerguntaId");

                    b.HasIndex("TemaId");

                    b.ToTable("Perguntas");
                });

            modelBuilder.Entity("WebAPI.Models.Tema", b =>
                {
                    b.Property<int>("TemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TemaId"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MateriaId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemaId");

                    b.HasIndex("MateriaId");

                    b.ToTable("Temas");
                });

            modelBuilder.Entity("WebAPI.Models.Pergunta", b =>
                {
                    b.HasOne("WebAPI.Models.Tema", "Tema")
                        .WithMany("Perguntas")
                        .HasForeignKey("TemaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tema");
                });

            modelBuilder.Entity("WebAPI.Models.Tema", b =>
                {
                    b.HasOne("WebAPI.Models.Materia", "Materia")
                        .WithMany("Temas")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materia");
                });

            modelBuilder.Entity("WebAPI.Models.Materia", b =>
                {
                    b.Navigation("Temas");
                });

            modelBuilder.Entity("WebAPI.Models.Tema", b =>
                {
                    b.Navigation("Perguntas");
                });
#pragma warning restore 612, 618
        }
    }
}
