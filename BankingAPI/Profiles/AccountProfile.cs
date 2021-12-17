using AutoMapper;
using BankingAPI.Data.DTOs;
using BankingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAPI.Profiles
{
  public class AccountProfile : Profile
  {
    public AccountProfile()
    {
      CreateMap<CreateAccountDTO, Account>();
      CreateMap<Account, ReadAccountDTO>();
      CreateMap<UpdateAccountDTO, Account>();
    }
  }
}
