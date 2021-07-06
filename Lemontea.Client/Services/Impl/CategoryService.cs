using Lemontea.Client.Api;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services.Impl
{
  public class CategoryService : ICategoryService
  {
    private readonly ILemonteaApi lemonteaApi;

    public CategoryService(ILemonteaApi lemonteaApi)
    {
      this.lemonteaApi = lemonteaApi;
    }

    public async Task<List<CategoryDto>> GetAsync()
    {
      return await lemonteaApi.GetCategories();
    }

    public async Task<CategoryDto> GetByIdAsync(Guid id)
    {
      return await lemonteaApi.GetCategoryById(id);
    }
  }
}
