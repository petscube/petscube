using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
namespace AdoptionBackend.security
{
 
  public class HeaderAuthenticationSchemeOption : AuthenticationSchemeOptions
  {
    public const string Name = "HeaderAuthenticationScheme";
  }
}
