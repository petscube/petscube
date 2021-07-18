using Application.abstraction;
using Domain;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Entities;
using Repositories.DbContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
  public class PetRepository : BaseRepository<Pet>, IPetRepository
  {
    public PetRepository(IDBContext dbContext) : base(dbContext, "Pets")
    {

      CreateIndex();
    }
    private async Task CreateIndex()
    {
      var indexKeysDefinition = Builders<Pet>.IndexKeys.Geo2DSphere(pet => pet.Location);
      await _collection.Indexes.CreateOneAsync(new CreateIndexModel<Pet>(indexKeysDefinition));

    }
    public async Task<IEnumerable<Pet>> GetPetsByEmail(string email)
    {
      var res = await _collection.FindAsync<Pet>(obj => true);
      return res.ToList();
    }
    public async Task<IEnumerable<Pet>> SearchPets(double latitude, double longitude, string filterType,
      string filterValue, int startIndex, int count)
    {
      FilterDefinition<Pet> filter1;
      if (filterType != null)
      {
        if (filterType.ToLower().Contains("breed"))
        {
          filter1 = Builders<Pet>.Filter.Where(p => p.Breed.Contains(filterValue));
        }
        else
        {
          filter1 = Builders<Pet>.Filter.Where(p => p.Category.Contains(filterValue));
        }
      }
      else
      {
        filter1 = Builders<Pet>.Filter.Empty;
      }
      var point = new GeoJsonPoint<GeoJson2DGeographicCoordinates>(new GeoJson2DGeographicCoordinates(longitude, latitude));
      var filterGeo = Builders<Pet>.Filter.NearSphere(doc => doc.Location, point);

      var filter = Builders<Pet>.Filter.And(
   filterGeo,
   filter1
            );

      var res = await _collection.Find<Pet>(filter).Skip(startIndex).
       Limit(count).ToListAsync();
      return res;
    }
  }
}
