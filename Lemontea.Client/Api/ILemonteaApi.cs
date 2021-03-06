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
    Task<List<AziendaDto>> GetAziende();

    [Get("/azienda/{id}")]
    Task<AziendaDto> GetAziendaById(int id);

    [Post("/azienda")]
    Task<ApiResponse<AziendaDto>> SaveAzienda(AziendaSaveRequest aziendaSaveRequest);

    [Put("/azienda")]
    Task<AziendaDto> EditAzienda(AziendaSaveRequest aziendaSaveRequest);

    [Delete("/azienda/{id}")]
    Task RemoveAzienda(int id);

    [Get("/azienda/search")]
    Task<List<AziendaDto>> SearchAziende(string ragioneSocialePattern, string codiceFiscalePattern);

    [Get("/azienda/categories")]
    Task<List<CategoryDto>> Categories(int id);


    [Get("/country")]
    Task<List<CountryDto>> GetCountries();

    [Get("/country/states")]
    Task<List<StateDto>> GetStatesByCountry(string alpha2Code);


    [Get("/contatto")]
    Task<List<ContattoDto>> GetContatti();

    [Get("/contatto/{id}")]
    Task<ContattoDto> GetContattoById(int id);

    [Post("/contatto")]
    Task<ContattoDto> SaveContatto(ContattoDto contattoDto);

    [Put("/contatto")]
    Task<ContattoDto> EditContatto(ContattoDto contattoDto);

    [Delete("/contatto/{id}")]
    Task RemoveContatto(int id);


    [Get("/category")]
    Task<List<CategoryDto>> GetCategories();

    [Get("/category/{id}")]
    Task<CategoryDto> GetCategoryById(Guid id);
  }
}
