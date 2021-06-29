using Lemontea.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Configurations
{
  public class AziendaConfiguration : IEntityTypeConfiguration<Azienda>
  {
    public void Configure(EntityTypeBuilder<Azienda> builder)
    {
      builder.HasMany(a => a.Categorie)
        .WithMany(c => c.Aziende)
        .UsingEntity(b => b.ToTable("AziendeCategorie"));
    }
  }
}
