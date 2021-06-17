using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdoptionBackend.security
{
  public static class HeaderAuthenticationSchemeExtensions
  {
    public static void UseHeaderAuthentication(this IServiceCollection services)
    {
      services.AddAuthentication(options => {
        options.DefaultScheme = HeaderAuthenticationSchemeOption.Name;
      })
      .AddScheme<HeaderAuthenticationSchemeOption,HeadeAuthenticationSchemeHandler>(
        HeaderAuthenticationSchemeOption.Name, option => { }
      );
    }
  }
}
