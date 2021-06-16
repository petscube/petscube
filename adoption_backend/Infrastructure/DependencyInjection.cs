using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
 
namespace Infrastructure
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {

      //map dependency injection here
      
      services.AddSingleton<AppDbContext>();
      
      return services;
    }
  }
}
