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
  public class CategoryController : Controller
  {
    private readonly ICategoryService categoryService;
    private readonly IAziendaService aziendaService;
    private readonly ILogger<CategoryController> logger;

    public CategoryController(ICategoryService categoryService, IAziendaService aziendaService, ILogger<CategoryController> logger)
    {
      this.categoryService = categoryService;
      this.aziendaService = aziendaService;
      this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> CategoriesCheckBoxes(int id)
    {
      var categorie = await categoryService.GetAsync();

      if (id != 0)
      {
        var aziendaCategorie = await aziendaService.GetCategoriesAsync(id);

        foreach (var category in aziendaCategorie)
        {
          var c = categorie.Find(c => c.Id == category.Id);
          if (c != null)
          {
            c.IsChecked = true;
          }
        }
      }

      return PartialView("_CategorieCheckBoxes", categorie);
    }
  }
}
