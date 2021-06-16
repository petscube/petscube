using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.DbContext
{
  public interface IDBContext
  {
    MongoCollectionBase<T> GetCollection<T>(string collectionName);
  }
 
}
