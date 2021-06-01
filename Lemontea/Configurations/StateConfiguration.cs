using Lemontea.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Configurations
{
  public class StateConfiguration : IEntityTypeConfiguration<State>
  {
    public void Configure(EntityTypeBuilder<State> builder)
    {
      builder.HasKey(s => new { s.CountryAlpha2Code, s.Alpha2Code });
    }
  }
}
