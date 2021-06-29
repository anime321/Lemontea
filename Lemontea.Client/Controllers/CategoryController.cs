using Lemontea.Client.Services;
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
    private readonly ILogger<CategoryController> logger;

    public CategoryController(ICategoryService categoryService, ILogger<CategoryController> logger)
    {
      this.categoryService = categoryService;
      this.logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
      var categorie = await categoryService.GetAsync();

      return Ok(categorie);
    }
  }
}
