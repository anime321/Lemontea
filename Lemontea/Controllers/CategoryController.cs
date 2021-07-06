using Lemontea.Common;
using Lemontea.Services;
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
  public class CategoryController : ControllerBaseEx
  {
    private readonly ICategoryService categoryService;

    public CategoryController(ICategoryService categoryService)
    {
      this.categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var result = await categoryService.GetAsync();
      var response = CreateResponse(result);

      return response;
    }

    [HttpGet("id")]
    public async Task<IActionResult> GetById(Guid id)
    {
      var result = await categoryService.GetByIdAsync(id);
      var response = CreateResponse(result);

      return response;
    }
  }
}
