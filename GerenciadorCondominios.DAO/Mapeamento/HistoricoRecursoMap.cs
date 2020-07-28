using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAO.Mapeamento
{
    public class HistoricoRecursoMap : IEntityTypeConfiguration<HistoricoRecurso>
    {
        public void Configure(EntityTypeBuilder<HistoricoRecurso> builder)
        {
            builder.HasKey(hr => hr.HistoricoRecursosId);
            builder.Property(hr => hr.Valor).IsRequired();
            builder.Property(hr => hr.Tipo).IsRequired();
            builder.Property(hr => hr.Dia).IsRequired();
            builder.Property(hr => hr.MesId).IsRequired();
            builder.Property(hr => hr.Valor).IsRequired();

            builder.HasOne(hr => hr.Mes).WithMany(hr => hr.HistoricoRecursos).HasForeignKey(hr => hr.MesId);

            builder.ToTable("HistoricoRecursos");
        }
    }
}
