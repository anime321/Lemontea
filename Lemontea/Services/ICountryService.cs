using Lemontea.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Services
{
  public interface ICountryService
  {
    Task<OperationResult> GetAsync();
    Task<OperationResult> GetStatesByCountry(string alpha2Code);
  }
}
