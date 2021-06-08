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
      return await lemonteaApi.GetAziende();
    }

    public async Task<Azienda> GetByIdAsync(int id)
    {
      return await lemonteaApi.GetAziendaById(id);
    }

    public async Task<Azienda> SaveAsync(AziendaDto aziendaDto)
    {
      return await lemonteaApi.SaveAzienda(aziendaDto);
    }

    public async Task<Azienda> EditAsync(AziendaDto aziendaDto)
    {
      return await lemonteaApi.EditAzienda(aziendaDto);
    }

    public async Task RemoveAsync(int id)
    {
      await lemonteaApi.RemoveAzienda(id);
    }

    public async Task<List<Azienda>> SearchAsync(string ragioneSocialePattern, string codiceFiscalePattern)
    {
      var aziende = await lemonteaApi.GetAziende();

      //
      // TODO: move logic to API project and use dbcontext
      //

      bool rsCheck = false;
      bool cfCheck = false;

      if (string.IsNullOrEmpty(ragioneSocialePattern) && string.IsNullOrEmpty(codiceFiscalePattern)) {
        return aziende;
      }

      if (!string.IsNullOrEmpty(ragioneSocialePattern))
      {
        rsCheck = true;
      }

      if (!string.IsNullOrEmpty(codiceFiscalePattern))
      {
        cfCheck = true;
      }

      Func<Azienda, bool> whereLambdaChecks = azienda =>
      {
        if (rsCheck && cfCheck)
        {
          return azienda.RagioneSociale.Contains(ragioneSocialePattern)
            && azienda.CodiceFiscale.Contains(codiceFiscalePattern);
        }
        else if (rsCheck)
        {
          return azienda.RagioneSociale.Contains(ragioneSocialePattern);
        }
        else if (cfCheck)
        {
          return azienda.CodiceFiscale.Contains(codiceFiscalePattern);
        }

        return false;
      };

      var result = aziende.Where(whereLambdaChecks).ToList();

      return result;
    }
  }
}
