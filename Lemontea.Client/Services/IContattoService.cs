using Lemontea.Client.Models;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services
{
  public interface IContattoService
  {
    Task<List<ContattoDto>> GetAsync();
    Task<ContattoDto> GetByIdAsync(int id);
    Task<ContattoDto> SaveAsync(ContattoDto contattoDto);
    Task<ContattoDto> EditAsync(ContattoDto contattoDto);
    Task RemoveAsync(int id);
  }
}
