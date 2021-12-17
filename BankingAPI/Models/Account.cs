﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAPI.Models
{
  public class Account
  {
    [Key]
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = "'Account' field is required.")]
    public int Number { get; set; }
    [Required(ErrorMessage = "'Owner' field is required.")]
    [StringLength(120, ErrorMessage = "The maximum char length for 'Owner' is 120.")]
    public string Owner { get; set; }
    public double Amount { get; set; }
  }
}