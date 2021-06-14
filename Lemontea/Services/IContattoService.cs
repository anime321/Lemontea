using Lemontea.Common;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Services
{
  public interface IContattoService
  {
    Task<OperationResult> GetAsync();
    Task<OperationResult> GetByIdAsync(int id);
    Task<OperationResult> SaveAsync(ContattoDto contattoDto);
    Task<OperationResult> EditAsync(ContattoDto contattoDto);
    Task<OperationResult> RemoveAsync(int id);
  }
}
