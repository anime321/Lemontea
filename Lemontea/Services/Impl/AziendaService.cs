using AutoMapper;
using Lemontea.Common;
using Lemontea.Entities;
using Lemontea.Shared.Models.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Services.Impl
{
  public class AziendaService : IAziendaService
  {
    private readonly ApplicationDbContext dbContext;
    private readonly IMapper mapper;
    private readonly ICategoryService categoryService;

    public AziendaService(ICategoryService categoryService, ApplicationDbContext dbContext, IMapper mapper)
    {
      this.categoryService = categoryService;
      this.dbContext = dbContext;
      this.mapper = mapper;
    }

    public async Task<OperationResult> GetAsync()
    {
      var aziende = await dbContext.Aziende.ToListAsync();
      var aziendeDto = mapper.Map<List<Azienda>, List<AziendaDto>>(aziende);

      return OperationResult.Ok(aziendeDto);
    }

    public async Task<OperationResult> GetByIdAsync(int id)
    {
      var azienda = await dbContext.Aziende.Include(a => a.Contatti).Include(a => a.Categorie).Where(a => a.Id == id).FirstOrDefaultAsync();

      var aziendaDto = mapper.Map<Azienda, AziendaDto>(azienda);

      return OperationResult.Ok(aziendaDto);
    }

    public async Task<OperationResult> SaveAsync(AziendaSaveRequest aziendaSaveRequest)
    {
      var azienda = mapper.Map<AziendaSaveRequest, Azienda>(aziendaSaveRequest);

      foreach (var c in azienda.Categorie)
      {
        dbContext.Entry(c).State = EntityState.Unchanged;
      }

      await dbContext.Aziende.AddAsync(azienda);
      await dbContext.SaveChangesAsync();

      var aziendaDto = mapper.Map<Azienda, AziendaDto>(azienda);

      return OperationResult.Ok(aziendaDto);
    }

    public async Task<OperationResult> EditAsync(AziendaSaveRequest aziendaSaveRequest)
    {
      var aziendaEntry = await dbContext.Aziende.Include(a => a.Categorie).Where(a => a.Id == aziendaSaveRequest.Id).FirstOrDefaultAsync();

      aziendaEntry.RagioneSociale = aziendaSaveRequest.RagioneSociale;
      aziendaEntry.Indirizzo      = aziendaSaveRequest.Indirizzo;
      aziendaEntry.NCivico        = aziendaSaveRequest.NCivico;
      aziendaEntry.CAP            = aziendaSaveRequest.CAP;
      aziendaEntry.Nazione        = aziendaSaveRequest.Nazione;
      aziendaEntry.Provincia      = aziendaSaveRequest.Provincia;
      aziendaEntry.Citta          = aziendaSaveRequest.Citta;
      aziendaEntry.Telefono       = aziendaSaveRequest.Telefono;
      aziendaEntry.Fax            = aziendaSaveRequest.Fax;
      aziendaEntry.Email          = aziendaSaveRequest.Email;
      aziendaEntry.SitoWeb        = aziendaSaveRequest.SitoWeb;
      aziendaEntry.PartitaIVA     = aziendaSaveRequest.PartitaIVA;
      aziendaEntry.CodiceFiscale  = aziendaSaveRequest.CodiceFiscale;

      foreach (var c in aziendaEntry.Categorie)
      {
        dbContext.Entry(c).State = EntityState.Unchanged;
      }

      await dbContext.SaveChangesAsync();

      var aziendaResp = mapper.Map<Azienda, AziendaDto>(aziendaEntry);
      return OperationResult.Ok(aziendaResp);
    }

    public async Task<OperationResult> RemoveAsync(int id)
    {
      var azienda = await dbContext.Aziende.Include(a => a.Contatti).Where(a => a.Id == id).SingleOrDefaultAsync();

      dbContext.Aziende.Remove(azienda);

      await dbContext.SaveChangesAsync();

      return OperationResult.Ok();
    }

    public async Task<OperationResult> SearchAziende(string ragioneSocialePattern, string codiceFiscalePattern)
    {
      List<Azienda> aziende;
      bool rsCheck = false;
      bool cfCheck = false;

      if (!string.IsNullOrEmpty(ragioneSocialePattern))
        rsCheck = true;

      if (!string.IsNullOrEmpty(codiceFiscalePattern))
        cfCheck = true;

      if (cfCheck || rsCheck)
      {
        if (rsCheck && !cfCheck)
        {
          aziende = await dbContext.Aziende.Where(a => a.RagioneSociale.Contains(ragioneSocialePattern)).ToListAsync();
        }
        else if (cfCheck && !rsCheck)
        {
          aziende = await dbContext.Aziende.Where(a => a.CodiceFiscale.Contains(codiceFiscalePattern)).ToListAsync();
        }
        else
        {
          aziende = await dbContext.Aziende.Where(a =>
            a.RagioneSociale.Contains(ragioneSocialePattern)
            && a.CodiceFiscale.Contains(codiceFiscalePattern)
            ).ToListAsync();
        }
      }
      else
      {
        aziende = await dbContext.Aziende.ToListAsync();
      }

      var aziendeDto = mapper.Map<List<Azienda>, List<AziendaDto>>(aziende);

      return OperationResult.Ok(aziendeDto);
    }

    public async Task<OperationResult> CategoriesByIdAsync(int id)
    {
      var azienda = await dbContext.Aziende.Include(a => a.Categorie).Where(a => a.Id == id).SingleOrDefaultAsync();
      var categorieDto = mapper.Map<List<Category>, List<CategoryDto>>(azienda.Categorie);

      return OperationResult.Ok(categorieDto);
    }
  }
}
