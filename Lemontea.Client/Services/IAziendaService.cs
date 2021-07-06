using Lemontea.Client.Models;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services
{
  public interface IAziendaService
  {
    Task<List<AziendaDto>> GetAsync();
    Task<AziendaDto> GetByIdAsync(int id);
    Task<List<CategoryDto>> GetCategoriesAsync(int id);
    Task<AziendaDto> SaveAsync(AziendaSaveRequest aziendaSaveRequest);
    Task<AziendaDto> EditAsync(AziendaDto aziendaDto);
    Task RemoveAsync(int id);
    Task<List<AziendaDto>> SearchAsync(string ragioneSocialePattern, string codiceFiscalePattern);
  }
}
