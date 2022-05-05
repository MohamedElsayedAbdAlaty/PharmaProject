using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using DAL;
using DAL.Model;
using ExcelDataReader;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace Presentation.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors(origins: "http://www.example.com", headers: "*", methods: "*")]
    public class SellerProductController : ControllerBase
    {
        private IBusinessService<seller_products_> businessService;
        private IHostingEnvironment _hosting;
        private IUploadFile _uploadFile;

        public SellerProductController(IBusinessService<seller_products_> business,
            IHostingEnvironment hosting, IUploadFile uploadFile)
        {
            businessService = business;
            _hosting = hosting;
            _uploadFile = uploadFile;
        }
        // GET: api/SellerProduct/get
        [HttpGet]
        [ActionName("get")]
        public IEnumerable<seller_products_> Get()
        {
            return businessService.GetAll();
        }
        [HttpPost]
        [ActionName("post")]
        public HttpResponseMessage  Post()
        {
            if (Request.Form.Files.Count == 0)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine(_hosting.WebRootPath, "Uploads");
                _uploadFile.Save(file, folderName);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }



        [HttpGet]
        [ActionName("Update")]
        public HttpResponseMessage Update()
        {
            try
            {
                if (businessService.Edit())
                {
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                else
                {
                    return new HttpResponseMessage(HttpStatusCode.NotFound);
                }
            }
            catch (Exception e)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
        }
    }
}
