using Lemontea.Profiles;
using Lemontea.Services;
using Lemontea.Services.Impl;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Extensions
{
  public static class ServiceCollectionExtension
  {
    public static void AddBusinessServices(this IServiceCollection services)
    {
      Type[] profileTypeArray = new Type[]
      {
        typeof(AziendaProfile)
      };

      services.AddAutoMapper(profileTypeArray);

      services.AddScoped<IAziendaService, AziendaService>();
    }
  }
}
