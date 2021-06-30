using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers
{
  public interface IFileHelper
  {
    Task UploadFile(Stream FileStream,string fileName);
  }
}
