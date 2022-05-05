﻿using DAL.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface IUploadFile
    {
         List<UpdateFile> GetData();
        void Save(IFormFile form,string path);
        
    }

}
