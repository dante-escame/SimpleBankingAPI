﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAPI.Data.DTOs
{
  public class ReadOwnerDTO
  {
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public string CPF { get; set; }
    [Required]
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
    public DateTime QueryCurrentTime { get; set; }
  }
}