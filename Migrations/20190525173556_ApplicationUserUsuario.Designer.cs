﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrjBiblioteca.Dados;

namespace PrjBiblioteca.Migrations
{
    [DbContext(typeof(BibliotecaDbContext))]
    [Migration("20190525173556_ApplicationUserUsuario")]
    partial class ApplicationUserUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("PrjBiblioteca.Models.Autor", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("AutorId");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(300);

                    b.HasKey("CategoriaID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataDevolucao");

                    b.Property<DateTime>("DataFim");

                    b.Property<DateTime>("DataInicio");

                    b.Property<string>("Nome");

                    b.Property<int>("UsuarioID");

                    b.HasKey("EmprestimoID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Emprestimo");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Livro", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Quantidade");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("LivroId");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.LivroAutor", b =>
                {
                    b.Property<int>("LivroID");

                    b.Property<int>("AutorID");

                    b.HasKey("LivroID", "AutorID");

                    b.HasIndex("AutorID");

                    b.ToTable("LivroAutor");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.LivroEmprestimo", b =>
                {
                    b.Property<int>("LivroID");

                    b.Property<int>("EmprestimoID");

                    b.HasKey("LivroID", "EmprestimoID");

                    b.HasIndex("EmprestimoID");

                    b.ToTable("LivroEmprestimo");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Sistema", b =>
                {
                    b.Property<int>("SistemaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("SistemaID");

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.SistemaUsuario", b =>
                {
                    b.Property<int>("SistemaID");

                    b.Property<int>("UsuarioID");

                    b.HasKey("SistemaID", "UsuarioID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("SistemaUsuario");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<int?>("CategoriaID");

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("UsuarioID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Emprestimo", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrjBiblioteca.Models.LivroAutor", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Autor", "Autores")
                        .WithMany("AutorLivros")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrjBiblioteca.Models.Livro", "Livros")
                        .WithMany("LivroAutores")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrjBiblioteca.Models.LivroEmprestimo", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Emprestimo", "Emprestimos")
                        .WithMany("EmprestimoLivros")
                        .HasForeignKey("EmprestimoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrjBiblioteca.Models.Livro", "Livros")
                        .WithMany("LivroEmprestimos")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrjBiblioteca.Models.SistemaUsuario", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Sistema", "Sistemas")
                        .WithMany("SistUsuarios")
                        .HasForeignKey("SistemaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrjBiblioteca.Models.Usuario", "Usuarios")
                        .WithMany("SistUsuarios")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Usuario", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Categoria", "Categoria")
                        .WithMany("Usuarios")
                        .HasForeignKey("CategoriaID");
                });
#pragma warning restore 612, 618
        }
    }
}
