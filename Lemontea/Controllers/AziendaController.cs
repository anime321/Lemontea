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
    public async Task<IActionResult> Save(AziendaDto aziendaDto)
    {
      var result = await aziendaService.SaveAsync(aziendaDto);
      var response = CreateResponse(result);

      return response;
    }

    [HttpPut]
    public async Task<IActionResult> Edit(AziendaDto aziendaDto)
    {
      var result = await aziendaService.EditAsync(aziendaDto);
      var response = CreateResponse(result);

      return response;
    }
  }
}
