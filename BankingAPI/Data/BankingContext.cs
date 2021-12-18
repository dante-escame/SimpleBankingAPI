using BankingAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAPI.Data
{
  public class BankingContext : DbContext
  {
    public BankingContext(DbContextOptions<BankingContext> opt) : base (opt)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Account>()
        .HasOne(a => a.Owner)
        .WithMany(o => o.Accounts)
        .HasForeignKey(a => a.OwnerId);
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Owner> Owners { get; set; }
  }
}
