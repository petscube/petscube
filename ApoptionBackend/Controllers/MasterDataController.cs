using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AdoptionBackend.Controllers
{
  [Route("adoption/masterdata")]
  [ApiController]
  public class MasterDataController : ControllerBase
  {
    // GET: api/<MasterDataController>
    [HttpGet("SearchSuggestion")]
    public IEnumerable<dynamic> SearchSuggestion()
    {
      List<dynamic> searchSuggestions = new List<dynamic>();
      searchSuggestions.Add(new { Text = "Dog", Type = "Category" });
      searchSuggestions.Add(new { Text = "Cat", Type = "Category" });
      searchSuggestions.Add(new { Text = "Labrador", Type = "Breed" });
      searchSuggestions.Add(new { Text = "German Shephered", Type = "Breed" });
      searchSuggestions.Add(new { Text = "Rabbit", Type = "Category" });
      searchSuggestions.Add(new { Text = "Bird", Type = "Category" });
      searchSuggestions.Add(new { Text = "Fish", Type = "Category" });
      searchSuggestions.Add(new { Text = "Spitz", Type = "Breed" });
      return searchSuggestions;
    }

    // GET api/<MasterDataController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<MasterDataController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<MasterDataController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<MasterDataController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
