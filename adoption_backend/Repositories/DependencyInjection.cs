using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Application.abstraction;
using Repositories.DbContext;

namespace Repositories
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
      services.AddSingleton<IDBContext, AppDBContext>();
      services.AddSingleton(typeof(IBaseRepository<>), typeof(BaseRepository<>));
      services.AddSingleton<IPetRepository, PetRepository>();

      //map dependency injection here
      return services;
    }
  }
}
