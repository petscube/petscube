using Domain;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace AdoptionBackend.security
{

 

  public class HeadeAuthenticationSchemeHandler
      : AuthenticationHandler<HeaderAuthenticationSchemeOption>
  {
    public HeadeAuthenticationSchemeHandler(
        IOptionsMonitor<HeaderAuthenticationSchemeOption> options,
        ILoggerFactory logger,
        UrlEncoder encoder,
        ISystemClock clock)
        : base(options, logger, encoder, clock)
    {
    }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {


      // validation comes in here
      if (Request.Headers.ContainsKey("Shared-Api-Token"))
      {
        var claims = new[] {

                    new Claim(ClaimTypes.Email, Request.Headers["Email"].ToString()),
                    new Claim("Pincode", Request.Headers["PinCode"].ToString()),
                    };

        // generate claimsIdentity on the name of the class
        var claimsIdentity = new ClaimsIdentity(claims,
                    nameof(HeadeAuthenticationSchemeHandler));

        // generate AuthenticationTicket from the Identity
        // and current authentication scheme
        var ticket = new AuthenticationTicket(
            new ClaimsPrincipal(claimsIdentity), this.Scheme.Name);
        return Task.FromResult(AuthenticateResult.Success(ticket));
      }
      else
      {
        //return Task.FromResult(AuthenticateResult.FaSuil("Invalid Request"));       
        return Task.FromResult(AuthenticateResult.Fail("Not Authorized"));
      }
    }
  }
}
