using Lemontea.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Configurations
{
  public class ContattoConfiguration : IEntityTypeConfiguration<Contatto>
  {
    public void Configure(EntityTypeBuilder<Contatto> builder)
    {
      builder
        .HasOne(c => c.Azienda)
        .WithMany(a => a.Contatti)
        .HasForeignKey(c => c.AziendaId)
        .OnDelete(DeleteBehavior.Cascade);
    }
  }
}