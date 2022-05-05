using DAL;
using DAL.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Business
{
    public class UploadFileBusiness : IUploadFile
    {
        private IFileOperation<UpdateFile> _fileOperation;
        public UploadFileBusiness(IFileOperation<UpdateFile> fileOperation)
        {
            _fileOperation = fileOperation;
        }
        public List<UpdateFile> GetData()
        {
           return  _fileOperation.GetData();
        }

        public void Save(IFormFile form, string path)
        {
            _fileOperation.Save(form, path);
        }
    }
}
