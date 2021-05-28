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
    Task<List<Azienda>> GetAsync();
    Task<Azienda> GetByIdAsync(int id);
    Task<Azienda> SaveAsync(AziendaDto aziendaDto);
    Task<Azienda> EditAsync(AziendaDto aziendaDto);
    Task RemoveAsync(int id);
  }
}
