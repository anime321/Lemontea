using Lemontea.Client.Models;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services
{
  public interface ICountryService
  {
    Task<List<CountryDto>> GetAsync();
    Task<List<StateDto>> GetStatesByCountryAsync(string alpha2Code);
  }
}
