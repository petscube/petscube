using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.services
{
  public interface IPetService:IBaseService<Pet>
  {
    Task<IEnumerable<Pet>> SearchPets(string category, string breed,
      string pinCode, int startIndex, int count);
    
  }
}
