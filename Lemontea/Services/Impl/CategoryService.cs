using AutoMapper;
using Lemontea.Common;
using Lemontea.Entities;
using Lemontea.Shared.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Services.Impl
{
  public class CategoryService : ICategoryService
  {
    private readonly ApplicationDbContext dbContext;
    private readonly IMapper mapper;

    public CategoryService(ApplicationDbContext dbContext, IMapper mapper)
    {
      this.dbContext = dbContext;
      this.mapper = mapper;
    }

    public async Task<OperationResult> GetAsync()
    {
      var categorie = await dbContext.Categorie.OrderBy(c => c.DisplayOrder).ToListAsync();
      var categorieDto = mapper.Map<List<Category>, List<CategoryDto>>(categorie);

      return OperationResult.Ok(categorieDto);
    }
  }
}
