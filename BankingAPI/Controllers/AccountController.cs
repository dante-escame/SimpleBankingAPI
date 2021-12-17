using AutoMapper;
using BankingAPI.Data;
using BankingAPI.Data.DTOs;
using BankingAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankingAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class AccountController : ControllerBase
  {
    private BankingContext _context;
    private IMapper _mapper;

    public AccountController(BankingContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddAccount([FromBody] CreateAccountDTO accountDTO)
    {
      Account account = _mapper.Map<Account>(accountDTO);
      _context.Accounts.Add(account);
      _context.SaveChanges();
      return CreatedAtAction(nameof(GetAccount), new { Id = account.Id }, account); // returns the status and where this resource was created
      // 201 (created)
    }

    [HttpGet]
    public IEnumerable<Account> GetAccounts()
    {
      return _context.Accounts;
      //return Ok(_context.Accounts);
      // this returns 200 even if the array is empty. This follows the REST pattern, because a empty array is a valid return for a generic GET
    }

    [HttpGet("{id}")]
    public IActionResult GetAccount(int id)
    {
      Account account = _context.Accounts.FirstOrDefault(a => a.Id == id);
      if (account != null)
      {
        ReadAccountDTO accountDTO = _mapper.Map<ReadAccountDTO>(account);
        return Ok(accountDTO);
      }
      return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAccount(int id, [FromBody] UpdateAccountDTO accountDTO)
    {
      Account account = _context.Accounts.FirstOrDefault(a => a.Id == id);
      if (account != null)
      {
        _mapper.Map(accountDTO, account);
        _context.SaveChanges();
        return NoContent(); // good practice
      }
      return NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAccount(int id)
    {
      Account account = _context.Accounts.FirstOrDefault(a => a.Id == id);
      if (account != null)
      {
        _context.Remove(account);
        _context.SaveChanges();
        return NoContent(); // good practice
      }
      return NotFound();
    }
  }
}
