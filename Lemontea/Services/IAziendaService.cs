using Lemontea.Common;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Services
{
  public interface IAziendaService
  {
    Task<OperationResult> GetAsync();
    Task<OperationResult> GetByIdAsync(int id);
    Task<OperationResult> SaveAsync(AziendaSaveRequest aziendaSaveRequest);
    Task<OperationResult> EditAsync(AziendaSaveRequest aziendaSaveRequest);
    Task<OperationResult> RemoveAsync(int id);
    Task<OperationResult> SearchAziende(string ragioneSocialePattern, string codiceFiscalePattern);
    Task<OperationResult> CategoriesByIdAsync(int id);
  }
}
