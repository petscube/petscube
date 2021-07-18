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
  [Route("adoption")]
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
    [HttpGet("GetByEmail/{email?}")]
    public async Task<IEnumerable<Pet>> GetByEmail(string email="")
    {
      return await _petService.GetPetsByEmail(email);
    }
    // GET api/<ValuesController>/5
    [HttpGet("search/{latitude}/{longitude}")]
    public async Task<IEnumerable<Pet>> Get(double latitude,double longitude,
     [FromQuery] string filterType,[FromQuery] string filterValue,[FromQuery] int startIndex,[FromQuery] int count)
    {
     
      return await _petService.SearchPets(latitude, longitude,filterType,filterValue, startIndex, count);
    }
     
    // POST api/<ValuesController>
    [HttpPost]
    //[Authorize(AuthenticationSchemes = HeaderAuthenticationSchemeOption.Name)]
    public async Task Post([FromForm] Pet pet)
    {
      for(var i = 0; i < 50; i++)
      {
        pet.Breed = pet.Breed + " " + i.ToString();
        pet.Id = null;
        await this._petService.Add(pet);
      }
      //await this._petService.Add(pet);
    }
 
    // DELETE api/<ValuesController>/5
    [HttpDelete("{id}")]
    public void Delete(string id)
    {
      this._petService.Delete(id);
    }
  }
}
