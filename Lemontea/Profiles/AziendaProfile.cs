using AutoMapper;
using Lemontea.Entities;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Profiles
{
  public class AziendaProfile : Profile
  {
    public AziendaProfile()
    {
      CreateMap<Azienda, AziendaDto>().ReverseMap();
      CreateMap<AziendaSaveRequest, Azienda>()
        .ForMember(
          dest => dest.Categorie,
          opt => opt.MapFrom(src => src.Categorie.Select(c => new Category(c)).ToList())
        );
    }
  }
}
