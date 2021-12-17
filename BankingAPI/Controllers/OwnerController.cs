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
  public class OwnerController : ControllerBase
  {
    private BankingContext _context;
    private IMapper _mapper;

    public OwnerController(BankingContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AddOwner([FromBody] CreateOwnerDTO OwnerDTO)
    {
      Owner Owner = _mapper.Map<Owner>(OwnerDTO);
      _context.Owners.Add(Owner);
      _context.SaveChanges();
      return CreatedAtAction(nameof(GetOwner), new { Id = Owner.Id }, Owner); // returns the status and where this resource was created
      // 201 (created)
    }

    [HttpGet]
    public IEnumerable<Owner> GetOwners()
    {
      return _context.Owners;
      //return Ok(_context.Owners);
      // this returns 200 even if the array is empty. This follows the REST pattern, because a empty array is a valid return for a generic GET
    }

    [HttpGet("{id}")]
    public IActionResult GetOwner(int id)
    {
      Owner Owner = _context.Owners.FirstOrDefault(a => a.Id == id);
      if (Owner != null)
      {
        ReadOwnerDTO OwnerDTO = _mapper.Map<ReadOwnerDTO>(Owner);
        return Ok(OwnerDTO);
      }
      return NotFound();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateOwner(int id, [FromBody] UpdateOwnerDTO OwnerDTO)
    {
      Owner Owner = _context.Owners.FirstOrDefault(a => a.Id == id);
      if (Owner != null)
      {
        _mapper.Map(OwnerDTO, Owner);
        _context.SaveChanges();
        return NoContent(); // good practice
      }
      return NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteOwner(int id)
    {
      Owner Owner = _context.Owners.FirstOrDefault(a => a.Id == id);
      if (Owner != null)
      {
        _context.Remove(Owner);
        _context.SaveChanges();
        return NoContent(); // good practice
      }
      return NotFound();
    }
  }
}
