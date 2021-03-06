using Lemontea.Client.Services;
using Lemontea.Shared.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Controllers
{
  public class ContattoController : Controller
  {
    private readonly IContattoService contattoService;
    private readonly ILogger<ContattoController> logger;

    public ContattoController(IContattoService contattoService, ILogger<ContattoController> logger)
    {
      this.contattoService = contattoService;
      this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var contatti = await contattoService.GetAsync();
      return View(contatti);
    }

    [HttpGet]
    public IActionResult AddDialog()
    {
      return PartialView("_EditContattoModal");
    }

    [HttpGet]
    public async Task<IActionResult> EditDialog(int id)
    {
      var contatto = await contattoService.GetByIdAsync(id);
      return PartialView("_EditContattoModal", contatto);
    }

    [HttpPost]
    public async Task<IActionResult> Save(ContattoDto contattoDto)
    {
      await contattoService.SaveAsync(contattoDto);
      return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> Edit(ContattoDto contattoDto)
    {
      await contattoService.EditAsync(contattoDto);
      return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> Remove(int id)
    {
      await contattoService.RemoveAsync(id);

      return Ok();
    }

  }
}
