using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAPI.Data.DTOs
{
  public record CreateAccountDTO
  {
    [Required]
    public int Number { get; set; }
    public double Amount { get; set; }
    public int OwnerId { get; set; }
  }

  public record ReadAccountDTO
  {
    public int Id { get; set; }
    public int Number { get; set; }
    public double Amount { get; set; }
    public DateTime QueryCurrentTime { get; set; }
  }

  public record UpdateAccountDTO
  {
    public int Number { get; set; }
    // &todo& - idea: change account's owner
    public double Amount { get; set; }
    public int OwnerId { get; set; }
  }

  public record CreateOwnerDTO
  {
    [Required]
    public string CPF { get; set; }
    [Required]
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
  }

  public record ReadOwnerDTO
  {
    public int Id { get; set; }
    public string CPF { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime QueryCurrentTime { get; set; }
  }

  public record UpdateOwnerDTO
  {
    public string CPF { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
  }
}
