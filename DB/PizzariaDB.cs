using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage;
using ProjetoInter.DB.Configuration;
using ProjetoInter.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInter.DB
{
    // DbContext é a classe da biblioteca "EntityFramework Pomelo" responsável por conter os métodos de acesso ao banco de dados
    public class PizzariaDB : DbContext
    {
        // método passando as configurações de conexão com o banco de dados.

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured) 
            {
                var stringConexao = "Server=localhost;Database=ProjetoPizzaria;User=root;Password=123456";
                options.UseMySql(stringConexao);
            }
        }

        // informando para o entity que ele terá uma tabela chamada usuários e que a classe usuário dentro de modelos será mapeada para representar a tabela e os campos dentro do banco de dados
        public DbSet<Usuario> Usuarios { get; set; }
    
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
        
        public DbSet<Estoque> Estoque { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new EstoqueConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }
    }
}
