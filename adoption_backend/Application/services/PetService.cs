using Application.abstraction;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.services
{
  public class PetService:BaseService<Pet>, IPetService
  {
    private IPetRepository _petrepo;
    public PetService(IPetRepository petRepo):base(petRepo)
    {
      _petrepo = petRepo;
    }
    public async Task<IEnumerable<Pet>> SearchPets(string category, string breed,
      string pinCode, int startIndex, int count)
    {
      return await _petrepo.SearchPets(category, breed,
       pinCode,  startIndex, count);
    }
  }
}
