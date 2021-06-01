using Lemontea.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Configurations
{
  public class CountryConfiguration : IEntityTypeConfiguration<Country>
  {
    public void Configure(EntityTypeBuilder<Country> builder)
    {
      builder.HasKey(c => new { c.Language, c.Alpha2Code });

      builder.HasMany(c => c.States)
        .WithOne();
    }
  }
}
