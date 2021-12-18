using System;
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
    [Required]
    public int Number { get; set; }
    public double Amount { get; set; }
    public virtual Owner Owner { get; set; }
    public int OwnerId { get; set; }
  }
}
