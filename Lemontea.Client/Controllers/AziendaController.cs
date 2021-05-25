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

    public async Task<IActionResult> Index()
    {
      var aziende = await aziendaService.GetAsync();
      return View(aziende);
    }

    public async Task<IActionResult> AddAzienda(int id)
    {
      if (id == 0)
      {
        return View();
      }

      var azienda = await aziendaService.GetByIdAsync(id);
      return View(azienda);
    }

    public async Task<IActionResult> SaveAzienda(AziendaDto aziendaDto)
    {
      await aziendaService.SaveAsync(aziendaDto);
      return RedirectToAction("Index");
    }

    public async Task<IActionResult> EditAzienda(AziendaDto aziendaDto)
    {
      await aziendaService.EditAsync(aziendaDto);
      return RedirectToAction("Index");
    }
  }
}
