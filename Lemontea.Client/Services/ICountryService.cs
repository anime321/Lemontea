using Lemontea.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services
{
  public interface ICountryService
  {
    Task<List<Country>> GetAsync();
  }
}
