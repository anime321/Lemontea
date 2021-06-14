using Lemontea.Client.Api;
using Lemontea.Client.Models;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Services.Impl
{
  public class ContattoService : IContattoService
  {
    private readonly ILemonteaApi lemonteaApi;

    public ContattoService(ILemonteaApi lemonteaApi)
    {
      this.lemonteaApi = lemonteaApi;
    }

    public async Task<List<Contatto>> GetAsync()
    {
      return await lemonteaApi.GetContatti();
    }

    public async Task<Contatto> GetByIdAsync(int id)
    {
      return await lemonteaApi.GetContattoById(id);
    }

    public async Task<Contatto> SaveAsync(ContattoDto contattoDto)
    {
      return await lemonteaApi.SaveContatto(contattoDto);
    }

    public async Task<Contatto> EditAsync(ContattoDto contattoDto)
    {
      return await lemonteaApi.EditContatto(contattoDto);
    }

    public async Task RemoveAsync(int id)
    {
      await lemonteaApi.RemoveContatto(id);
    }
  }
}
