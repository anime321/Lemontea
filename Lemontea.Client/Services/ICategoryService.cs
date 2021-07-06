using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services
{
  public interface ICategoryService
  {
    Task<List<CategoryDto>> GetAsync();
    Task<CategoryDto> GetByIdAsync(Guid id);
  }
}
