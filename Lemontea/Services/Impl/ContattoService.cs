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
  public class ContattoService : IContattoService
  {
    private readonly ApplicationDbContext dbContext;
    private readonly IMapper mapper;

    public ContattoService(ApplicationDbContext dbContext, IMapper mapper)
    {
      this.dbContext = dbContext;
      this.mapper = mapper;
    }

    public async Task<OperationResult> GetAsync()
    {
      var contatti = await dbContext.Contatti.ToListAsync();
      var contattiDto = mapper.Map<List<Contatto>, List<ContattoDto>>(contatti);

      return OperationResult.Ok(contattiDto);
    }

    public async Task<OperationResult> GetByIdAsync(int id)
    {
      var contatto = await dbContext.Contatti.FindAsync(id);
      var contattoDto = mapper.Map<Contatto, ContattoDto>(contatto);

      return OperationResult.Ok(contattoDto);
    }

    public async Task<OperationResult> SaveAsync(ContattoDto contattoDto)
    {
      var contatto = mapper.Map<ContattoDto, Contatto>(contattoDto);

      await dbContext.Contatti.AddAsync(contatto);
      await dbContext.SaveChangesAsync();

      return OperationResult.Ok();
    }

    public async Task<OperationResult> EditAsync(ContattoDto contattoDto)
    {
      var contatto = await dbContext.Contatti.FindAsync(contattoDto.Id);

      contatto.Nome      = contattoDto.Nome;
      contatto.Cognome   = contattoDto.Cognome;
      contatto.Email     = contattoDto.Email;
      contatto.Telefono  = contattoDto.Telefono;
      contatto.Cellulare = contattoDto.Cellulare;

      await dbContext.SaveChangesAsync();

      return OperationResult.Ok(contatto);
    }

    public async Task<OperationResult> RemoveAsync(int id)
    {
      var contatto = await dbContext.Contatti.FindAsync(id);
      dbContext.Contatti.Remove(contatto);

      await dbContext.SaveChangesAsync();

      return OperationResult.Ok();
    }
  }
}
