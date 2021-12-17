using AutoMapper;
using BankingAPI.Data.DTOs;
using BankingAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAPI.Profiles
{
  public class AccountProfiler : Profile
  {
    public AccountProfiler()
    {
      CreateMap<CreateAccountDTO, Account>();
      CreateMap<Account, ReadAccountDTO>();
      CreateMap<UpdateAccountDTO, Account>();
    }

    
  }
}
