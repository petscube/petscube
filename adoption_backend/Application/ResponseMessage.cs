using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Application
{
  public class ResponseMessage
  {
    public ResponseMessage(HttpStatusCode statusCode,object data)
    {
      StatusCode = (int)statusCode;
      Data = data;
    }
    public int StatusCode { get; set; }
    public object Data { get; set; }
  }
 
}
