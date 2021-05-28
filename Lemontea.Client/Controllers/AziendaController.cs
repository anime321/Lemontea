﻿using Lemontea.Client.Services;
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
    public async Task<IActionResult> SaveAzienda(AziendaDto aziendaDto)
    {
      if (!ModelState.IsValid)
      {
        return View("AddAzienda");
      }

      await aziendaService.SaveAsync(aziendaDto);
      return View(nameof(Index));
    }

    [HttpPut]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> EditAzienda(AziendaDto aziendaDto)
    {
      if (!ModelState.IsValid)
      {
        return View("AddAzienda", aziendaDto.Id);
      }

      await aziendaService.EditAsync(aziendaDto);
      return View(nameof(Index));
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveAzienda(int id)
    {
      await aziendaService.RemoveAsync(id);
      return View(nameof(Index));
    }
  }
}
