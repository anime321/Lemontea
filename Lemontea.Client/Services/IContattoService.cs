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
    Task<List<Contatto>> GetAsync();
    Task<Contatto> GetByIdAsync(int id);
    Task<Contatto> SaveAsync(ContattoDto contattoDto);
    Task<Contatto> EditAsync(ContattoDto contattoDto);
    Task RemoveAsync(int id);
  }
}
