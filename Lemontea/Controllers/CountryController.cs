using Lemontea.Common;
using Lemontea.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CountryController : ControllerBaseEx
  {
    private readonly ICountryService countryService;

    public CountryController(ICountryService countryService)
    {
      this.countryService = countryService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var result = await countryService.GetAsync();
      var response = CreateResponse(result);

      return response;
    }
  }
}
