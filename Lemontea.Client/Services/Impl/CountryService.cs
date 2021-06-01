using Lemontea.Client.Api;
using Lemontea.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services.Impl
{
  public class CountryService
  {
    private readonly ILemonteaApi lemonteaApi;

    public CountryService(ILemonteaApi lemonteaApi)
    {
      this.lemonteaApi = lemonteaApi;
    }
    
    public async Task<List<Country>> GetAsync()
    {
      return await lemonteaApi.GetCountries();
    }
  }
}
