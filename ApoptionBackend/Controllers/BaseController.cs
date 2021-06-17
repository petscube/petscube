using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;

namespace AdoptionBackend.Controllers
{
  public class BaseController: ControllerBase
  {
    protected string _userEmail;
    protected string _pinCode;
    protected BaseController()
    {
      if (User != null)
      {
        _userEmail = User.FindFirst(ClaimTypes.Email).Value;
        _pinCode = User.FindFirst("PinCode").Value;
      }
    }
  }
}
