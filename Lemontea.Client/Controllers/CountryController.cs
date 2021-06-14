using Lemontea.Client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Controllers
{
  public class CountryController : ControllerBase
  {
    private readonly ICountryService countryService;
    private readonly ILogger<CountryController> logger;

    public CountryController(ICountryService countryService, ILogger<CountryController> logger)
    {
      this.countryService = countryService;
      this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get_Countries()
    {
      var countries = await countryService.GetAsync();
      return Ok(countries);
    }

    [HttpGet]
    public async Task<IActionResult> Get_StatesByCountry(string alpha2Code)
    {
      var states = await countryService.GetStatesByCountryAsync(alpha2Code);
      return Ok(states);
    }
  }
}
