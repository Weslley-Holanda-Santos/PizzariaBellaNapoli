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
    internal class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Produto).HasColumnType("varchar(30)").IsRequired();

            builder.Property(x => x.Valor).HasColumnType("double").IsRequired();

            builder.Property(x => x.ClienteId).HasColumnType("int").IsRequired();
        }
    }
}
