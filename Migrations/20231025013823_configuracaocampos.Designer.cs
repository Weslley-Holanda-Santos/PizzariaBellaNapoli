﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoInter.DB;

namespace ProjetoInter.Migrations
{
    [DbContext(typeof(PizzariaDB))]
    [Migration("20231025013823_configuracaocampos")]
    partial class configuracaocampos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoInter.Modelos.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("Varchar(14)")
                        .HasMaxLength(14);

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProjetoInter.Modelos.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoriaProduto")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DescricaoProduto")
                        .IsRequired()
                        .HasColumnType("varchar(400)");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<int>("QuantidadeProduto")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("ProjetoInter.Modelos.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Produto")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ProjetoInter.Modelos.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(12)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProjetoInter.Modelos.Pedido", b =>
                {
                    b.HasOne("ProjetoInter.Modelos.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
