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
  public class ContattoController : ControllerBaseEx
  {
    private readonly IContattoService contattoService;

    public ContattoController(IContattoService contattoService)
    {
      this.contattoService = contattoService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var result = await contattoService.GetAsync();
      var response = CreateResponse(result);

      return response;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
      var result = await contattoService.GetByIdAsync(id);
      var response = CreateResponse(result);

      return response;
    }

    [HttpPost]
    public async Task<IActionResult> Save(ContattoDto contattoDto)
    {
      var result = await contattoService.SaveAsync(contattoDto);
      var response = CreateResponse(result);

      return response;
    }

    [HttpPut]
    public async Task<IActionResult> Edit(ContattoDto contattoDto)
    {
      var result = await contattoService.EditAsync(contattoDto);
      var response = CreateResponse(result);

      return response;
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Remove(int id)
    {
      var result = await contattoService.RemoveAsync(id);
      var response = CreateResponse(result);

      return response;
    }
  }
}
