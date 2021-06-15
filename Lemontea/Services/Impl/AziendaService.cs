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

    public AziendaService(ApplicationDbContext dbContext, IMapper mapper)
    {
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
      // var azienda = await dbContext.Aziende.Where(a => a.Id == id).SingleAsync();
      var azienda = await dbContext.Aziende.FindAsync(id);
      var aziendaDto = mapper.Map<Azienda, AziendaDto>(azienda);

      return OperationResult.Ok(aziendaDto);
    }

    public async Task<OperationResult> SaveAsync(AziendaDto aziendaDto)
    {
      var azienda = mapper.Map<AziendaDto, Azienda>(aziendaDto);

      await dbContext.Aziende.AddAsync(azienda);
      await dbContext.SaveChangesAsync();

      aziendaDto.Id = azienda.Id;

      return OperationResult.Ok(aziendaDto);
    }

    public async Task<OperationResult> EditAsync(AziendaDto aziendaDto)
    {
      var azienda = await dbContext.Aziende.FindAsync(aziendaDto.Id);

      azienda.RagioneSociale = aziendaDto.RagioneSociale;
      azienda.Indirizzo      = aziendaDto.Indirizzo;
      azienda.NCivico        = aziendaDto.NCivico;
      azienda.CAP            = aziendaDto.CAP;
      azienda.Nazione        = aziendaDto.Nazione;
      azienda.Provincia      = aziendaDto.Provincia;
      azienda.Citta          = aziendaDto.Citta;
      azienda.Telefono       = aziendaDto.Telefono;
      azienda.Fax            = aziendaDto.Fax;
      azienda.Email          = aziendaDto.Email;
      azienda.SitoWeb        = aziendaDto.SitoWeb;
      azienda.PartitaIVA     = aziendaDto.PartitaIVA;
      azienda.CodiceFiscale  = aziendaDto.CodiceFiscale;

      await dbContext.SaveChangesAsync();

      return OperationResult.Ok(aziendaDto);
    }

    public async Task<OperationResult> RemoveAsync(int id)
    {
      var azienda = await dbContext.Aziende.FindAsync(id);
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
  }
}
