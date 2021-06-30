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
  public class AziendaController : Controller
  {
    private readonly IAziendaService aziendaService;
    private readonly ILogger<AziendaController> logger;

    public AziendaController(IAziendaService aziendaService, ILogger<AziendaController> logger)
    {
      this.aziendaService = aziendaService;
      this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var aziende = await aziendaService.GetAsync();
      return View(aziende);
    }

    [HttpGet]
    public async Task<IActionResult> Get_Aziende()
    {
      var aziende = await aziendaService.GetAsync();
      return Ok(aziende);
    }

    [HttpGet]
    public async Task<IActionResult> DettaglioAzienda(int id)
    {
      var azienda = await aziendaService.GetByIdAsync(id);
      return View("DettaglioAzienda", azienda);
    }

    [HttpGet]
    public async Task<IActionResult> AddAzienda(int id)
    {
      if (id == 0)
      {
        return View();
      }

      var azienda = await aziendaService.GetByIdAsync(id);
      return View(azienda);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> SaveAzienda(AziendaSaveRequest aziendaSaveRequest)
    {
      await aziendaService.SaveAsync(aziendaSaveRequest);
      return Ok();
    }

    [HttpPut]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditAzienda(AziendaDto aziendaDto)
    {
      await aziendaService.EditAsync(aziendaDto);
      return Ok();
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveAzienda(int id)
    {
      await aziendaService.RemoveAsync(id);
      return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> Search()
    {
      var aziende = await aziendaService.GetAsync();
      return View(aziende);
    }

    [HttpGet]
    public async Task<IActionResult> SearchAzienda(string ragioneSocialePattern, string codiceFiscalePattern)
    {
      var aziende = await aziendaService.SearchAsync(ragioneSocialePattern, codiceFiscalePattern);
      return PartialView("_SearchResults", aziende);
    }
  }
}
