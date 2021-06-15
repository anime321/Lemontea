using Lemontea.Client.Api;
using Lemontea.Client.Models;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services.Impl
{
  public class CountryService : ICountryService
  {
    private readonly ILemonteaApi lemonteaApi;

    public CountryService(ILemonteaApi lemonteaApi)
    {
      this.lemonteaApi = lemonteaApi;
    }

    public async Task<List<CountryDto>> GetAsync()
    {
      return await lemonteaApi.GetCountries();
    }

    public async Task<List<StateDto>> GetStatesByCountryAsync(string alpha2Code)
    {
      return await lemonteaApi.GetStatesByCountry(alpha2Code);
    }
  }
}
