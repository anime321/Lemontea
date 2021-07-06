using Lemontea.Common;
using Lemontea.Services;
using Lemontea.Shared.Models.Dto;
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
  public class AziendaController : ControllerBaseEx
  {
    private readonly IAziendaService aziendaService;

    public AziendaController(IAziendaService aziendaService)
    {
      this.aziendaService = aziendaService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var result = await aziendaService.GetAsync();
      var response = CreateResponse(result);

      return response;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var result = await aziendaService.GetByIdAsync(id);
      var response = CreateResponse(result);

      return response;
    }

    [HttpPost]
    public async Task<IActionResult> Save(AziendaSaveRequest aziendaSaveRequest)
    {
      var result = await aziendaService.SaveAsync(aziendaSaveRequest);
      var response = CreateResponse(result);

      return response;
    }

    [HttpPut]
    public async Task<IActionResult> Edit(AziendaSaveRequest aziendaSaveRequest)
    {
      var result = await aziendaService.EditAsync(aziendaSaveRequest);
      var response = CreateResponse(result);

      return response;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(int id)
    {
      var result = await aziendaService.RemoveAsync(id);
      var response = CreateResponse(result);

      return response;
    }

    [HttpGet("categories")]
    public async Task<IActionResult> Categories(int id)
    {
      var result = await aziendaService.CategoriesByIdAsync(id);
      var response = CreateResponse(result);

      return response;
    }

    [HttpGet("search")]
    public async Task<IActionResult> Search(string ragioneSocialePattern, string codiceFiscalePattern)
    {
      var result = await aziendaService.SearchAziende(ragioneSocialePattern, codiceFiscalePattern);
      var response = CreateResponse(result);

      return response;
    }
  }
}
