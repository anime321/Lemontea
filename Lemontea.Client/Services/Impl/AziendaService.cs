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

    public async Task<List<AziendaDto>> GetAsync()
    {
      return await lemonteaApi.GetAziende();
    }

    public async Task<AziendaDto> GetByIdAsync(int id)
    {
      return await lemonteaApi.GetAziendaById(id);
    }

    public async Task<List<CategoryDto>> GetCategoriesAsync(int id)
    {
      return await lemonteaApi.Categories(id);
    }

    public async Task<AziendaDto> SaveAsync(AziendaSaveRequest aziendaSaveRequest)
    {
      var response = await lemonteaApi.SaveAzienda(aziendaSaveRequest);
      return response.Content;
    }

    public async Task<AziendaDto> EditAsync(AziendaSaveRequest aziendaSaveRequest)
    {
      return await lemonteaApi.EditAzienda(aziendaSaveRequest);
    }

    public async Task RemoveAsync(int id)
    {
      await lemonteaApi.RemoveAzienda(id);
    }

    public async Task<List<AziendaDto>> SearchAsync(string ragioneSocialePattern, string codiceFiscalePattern)
    {
      return await lemonteaApi.SearchAziende(ragioneSocialePattern, codiceFiscalePattern);
    }
  }
}
