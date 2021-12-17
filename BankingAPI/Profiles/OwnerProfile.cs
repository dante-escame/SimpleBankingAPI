using AutoMapper;
using BankingAPI.Data.DTOs;
using BankingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAPI.Profiles
{
  public class OwnerProfile : Profile
  {
    public OwnerProfile()
    {
      CreateMap<CreateOwnerDTO, Owner>();
      CreateMap<Owner, ReadOwnerDTO>();
      CreateMap<UpdateOwnerDTO, Owner>();
    }
  }
}
