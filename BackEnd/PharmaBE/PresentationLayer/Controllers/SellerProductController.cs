using BusinessLayer.Business;
using DAL;
using DAL.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PresentationLayer.Controllers
{
    public class SellerProductController : ApiController
    {
        public SellerProductController()
        {

        }

        //for dependency injection using unity 
        private IBusinessService<seller_products_> ipbusiness;
        public SellerProductController(IBusinessService<seller_products_> ip)
        {
            ipbusiness = ip;
        }

        [HttpGet]
        [Route("api/Seller_products_/GetProducts")]
        public List<seller_products_> GetProducts()
        {

            return ipbusiness.GetAll().ToList();
        }
        // GET: api/SellerProduct
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1 ", "value2" };
        //}

        //// GET: api/SellerProduct/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/SellerProduct
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SellerProduct/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SellerProduct/5
        public void Delete(int id)
        {
        }
    }
}
