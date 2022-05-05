using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface  IFileOperation<T>
    {
        List<T> GetData();
        bool Save(IFormFile form, string path);

    }
}
