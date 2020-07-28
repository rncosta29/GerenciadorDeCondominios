using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAO.Mapeamento
{
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(a => a.ApartamentoId);
            builder.Property(a => a.Numero).IsRequired();
            builder.Property(v => v.Andar).IsRequired();
            builder.Property(v => v.Foto).IsRequired();
            builder.Property(v => v.ProprietarioId).IsRequired();
            builder.Property(v => v.MoradorId).IsRequired(false);

            builder.HasOne(a => a.Proprietario).WithMany(a => a.ProprietariosApartamentos).HasForeignKey(a => a.ProprietarioId).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(a => a.Morador).WithMany(a => a.MoradoresApartamentos).HasForeignKey(a => a.MoradorId).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Apartamentos");
        }
    }
}
