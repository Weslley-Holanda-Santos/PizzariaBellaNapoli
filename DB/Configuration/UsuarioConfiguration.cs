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
    internal class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).HasColumnType("varchar(100)").IsRequired();

            builder.Property(x => x.Cargo).HasColumnType("varchar(30)").IsRequired();

            builder.Property(x => x.Login).HasColumnType("varchar(10)").IsRequired();

            builder.Property(x => x.Senha).HasColumnType("varchar(12)").IsRequired();
        }
    }
}
