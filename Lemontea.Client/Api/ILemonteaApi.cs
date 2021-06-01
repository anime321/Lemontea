﻿using Lemontea.Client.Models;
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
    Task<List<Azienda>> GetAziende();

    [Get("/azienda/{id}")]
    Task<Azienda> GetAziendaById(int id);

    [Post("/azienda")]
    Task<Azienda> SaveAzienda(AziendaDto aziendaDto);

    [Put("/azienda")]
    Task<Azienda> EditAzienda(AziendaDto aziendaDto);

    [Delete("/azienda/{id}")]
    Task RemoveAzienda(int id);


    [Get("/country")]
    Task<List<Country>> GetCountries();
  }
}
