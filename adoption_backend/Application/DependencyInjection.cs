using Application.services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
      services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
      services.AddSingleton(typeof(IBaseService<>), typeof(BaseService<>));
      services.AddSingleton<IPetService, PetService>();
      //map dependency injection here
      return services;
    }
  }
}
