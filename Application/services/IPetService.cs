using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.services
{
  public interface IPetService:IBaseService<Pet>
  {
    Task<IEnumerable<Pet>> SearchPets(double latitude, double longitude, string filterType,
      string filterValue, int startIndex, int count);
    Task<IEnumerable<Pet>> GetPetsByEmail(string email);

  }
}
