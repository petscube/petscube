using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Domain;
using System.Linq;
using System.Threading.Tasks;
using Application.services;
using Microsoft.AspNetCore.Authorization;
using AdoptionBackend.helpers;
using AdoptionBackend.security;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdoptionBackend.Controllers
{
  
  [ApiController]
  [Route("api/adoption")]
  public class PetsController : BaseController
  {
    private IPetService _petService;
      public PetsController(IPetService petService)
      {
      _petService = petService;
      }
    // GET: api/<ValuesController>
    [HttpGet]
    [Route("{id}")]
    public async Task<Pet> Get(string id)
    {
      return await _petService.Get(id);
    }

    // GET api/<ValuesController>/5
    [HttpGet("/search/{category}/{breed}")]
    public async Task<IEnumerable<Pet>> Get(string category,string breed, [FromQuery] int startIndex,int count)
    {
     
      return await _petService.SearchPets(category, breed, _pinCode, startIndex, count);
    }

    // POST api/<ValuesController>
    [HttpPost]
    [Authorize(AuthenticationSchemes = HeaderAuthenticationSchemeOption.Name)]
    public void Post([FromBody] Pet pet)
    {
        this._petService.Add(pet);
    }

    // PUT api/<ValuesController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ValuesController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
