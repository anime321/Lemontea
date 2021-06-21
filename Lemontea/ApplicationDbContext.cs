using Lemontea.Configurations;
using Lemontea.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<Azienda> Aziende { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<Contatto> Contatti { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new AziendaConfiguration());
      modelBuilder.ApplyConfiguration(new ContattoConfiguration());
      modelBuilder.ApplyConfiguration(new CountryConfiguration());
      modelBuilder.ApplyConfiguration(new StateConfiguration());
    }
  }
}
