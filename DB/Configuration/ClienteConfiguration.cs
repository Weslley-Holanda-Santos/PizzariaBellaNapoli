using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoInter.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInter.DB.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // definir a chave primária para ID

            builder.HasKey(x => x.Id);

            //atributos dentro da classe cliente

            //prpriedade nome, tipo de propriedade e é obrigatória
            builder.Property(x => x.Name).HasColumnType("Varchar(100)").IsRequired();

            builder.Property(x => x.Endereco).HasColumnType("Varchar(50)").IsRequired();

            builder.Property(x => x.Telefone).HasColumnType("Varchar(15)").HasMaxLength(15).IsRequired();
        }
    }
}
