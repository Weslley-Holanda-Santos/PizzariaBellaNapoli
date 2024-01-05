using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoInter.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInter.DB.Configuration
{
    internal class EstoqueConfiguration : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.Property(x => x.NomeProduto).HasColumnType("varchar(30)").IsRequired();

            builder.Property(x => x.QuantidadeProduto).HasColumnType("int").IsRequired();

            builder.Property(x => x.DescricaoProduto).HasColumnType("varchar(400)").IsRequired();

            builder.Property(x => x.CategoriaProduto).HasColumnType("varchar(50)").IsRequired();

            builder.Property(x => x.Valor).HasColumnType("double").IsRequired();
        }
    }
}
