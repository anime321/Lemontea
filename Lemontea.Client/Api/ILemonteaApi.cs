using Lemontea.Client.Models;
using Lemontea.Shared.Models.Dto;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Client.Api
{
  public interface ILemonteaApi
  {
    [Get("/azienda")]
    Task<List<Azienda>> Get();

    [Get("/azienda/{id}")]
    Task<Azienda> GetById(int id);

    [Post("/azienda")]
    Task<Azienda> Save(AziendaDto aziendaDto);

    [Put("/azienda")]
    Task<Azienda> Edit(AziendaDto aziendaDto);

    [Delete("/azienda/{id}")]
    Task Remove(int id);
  }
}
