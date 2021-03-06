using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BankingAPI.Models
{
  public class Owner
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
    [JsonIgnore]
    public virtual List<Account> Accounts { get; set; }
  }
}
