using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.DbContext
{
   public class AppDBContext : IDBContext
  {
    private IMongoDatabase db;
    public AppDBContext(IConfiguration configuration)
    {
      var connString = configuration.GetValue<string>("DbSetting:ConnectionString");
      var client = new MongoClient(connString);
      db = client.GetDatabase(configuration.GetValue<string>("DbSetting:DbName"));
    }

    public MongoCollectionBase<T> GetCollection<T>(string collectionName)
    {
      return (MongoCollectionBase<T>)db.GetCollection<T>(collectionName);
    }
  }
}
