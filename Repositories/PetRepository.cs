using Application.abstraction;
using Domain;
using MongoDB.Driver;
using Repositories.DbContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
  public class PetRepository:BaseRepository<Pet>, IPetRepository
  {
    public PetRepository(IDBContext dbContext):base(dbContext,"Pets")
    {

    }
    public async Task<IEnumerable<Pet>> SearchPets(string category, string breed,
      string pinCode,int startIndex,int count)
    {
      var res = await _collection.Find<Pet>(obj => obj.PinCode==pinCode &&
      obj.Breed==breed && obj.Category==category).Skip(startIndex).
       Limit(count).ToListAsync();
      return res;
    }
  }
}
