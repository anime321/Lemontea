using Lemontea.Client.Api;
using Lemontea.Client.Models;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services.Impl
{
  public class AziendaService : IAziendaService
  {
    private readonly ILemonteaApi lemonteaApi;

    public AziendaService(ILemonteaApi lemonteaApi)
    {
      this.lemonteaApi = lemonteaApi;
    }

    public async Task<List<Azienda>> GetAsync()
    {
      return await lemonteaApi.Get();
    }

    public async Task<Azienda> GetByIdAsync(int id)
    {
      return await lemonteaApi.GetById(id);
    }

    public async Task<Azienda> SaveAsync(AziendaDto aziendaDto)
    {
      return await lemonteaApi.Save(aziendaDto);
    }

    public async Task<Azienda> EditAsync(AziendaDto aziendaDto)
    {
      return await lemonteaApi.Edit(aziendaDto);
    }

    public async Task RemoveAsync(int id)
    {
      await lemonteaApi.Remove(id);
    }
  }
}
