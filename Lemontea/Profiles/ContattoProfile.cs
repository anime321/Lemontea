using AutoMapper;
using Lemontea.Entities;
using Lemontea.Shared.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lemontea.Profiles
{
  public class ContattoProfile : Profile
  {
    public ContattoProfile()
    {
      CreateMap<Contatto, ContattoDto>().ReverseMap();
    }
  }
}
