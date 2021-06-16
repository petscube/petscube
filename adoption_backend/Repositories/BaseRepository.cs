using Application.abstraction;
using Domain;
 
using MongoDB.Bson;
using MongoDB.Driver;
using Repositories.DbContext;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
  public  class BaseRepository<TEntity>: IBaseRepository<TEntity> where TEntity : BaseEntity
  {
  
    protected MongoCollectionBase<TEntity> _collection;
    public BaseRepository(IDBContext dbContext,string collection)
    {
      _collection = dbContext.GetCollection<TEntity>(collection);
    }
    public async Task<List<TEntity>> GetAll(int startIndex,int count)
    {
      var res = await _collection.Find<TEntity>(obj => true).Skip(startIndex).
        Limit(count).ToListAsync();
      return res;
    }
    public async Task<bool> Delete(string id)
    {
      var entity = await _collection.DeleteOneAsync(obj => obj.Id == id);
      return entity.DeletedCount > 0;

    }

    public async Task<TEntity> Get(string id)
    {
      var result= await _collection.FindAsync<TEntity>(obj => obj.Id == id);
      return result.FirstOrDefault();
    }
    public async Task<TEntity> Update(TEntity entity)
    {
       
      await _collection.ReplaceOneAsync<TEntity>(obj=>obj.Id==entity.Id, entity);
      return entity;
    }
    public async Task Add(TEntity entity)
    {
       await _collection.InsertOneAsync(entity);
       
    }
 

   

    
  }
}
