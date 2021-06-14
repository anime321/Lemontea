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
  public class CountryService : ICountryService
  {
    private readonly ApplicationDbContext dbContext;
    private readonly IMapper mapper;

    public CountryService(ApplicationDbContext dbContext, IMapper mapper)
    {
      this.dbContext = dbContext;
      this.mapper = mapper;
    }

    public async Task<OperationResult> GetAsync()
    {
      var countries = await dbContext.Countries.Where(c => c.Language == "IT").ToListAsync();
      var countriesDto = mapper.Map<List<Country>, List<CountryDto>>(countries);

      return OperationResult.Ok(countriesDto);
    }

    public async Task<OperationResult> GetStatesByCountry(string alpha2Code)
    {
      if (alpha2Code != "IT")
        return OperationResult.Ok(new List<State>());

      var states = await dbContext.States.ToListAsync();

      return OperationResult.Ok(states);
    }
  }
}
