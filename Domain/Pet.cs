using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
 
namespace Domain
{
  public class Pet:BaseEntity
  {
     
   public string Name { get; set; }
   public int Age { get; set; }
   public string Contact { get; set; }
    public string Gender { get; set; }
   public string PinCode { get; set; }
   public string Category { get; set; }
   public string Breed { get; set; }
   public string Description { get; set; }
    public IFormFile Image { get; set; }

  }
}
