using BusinessLayer.Business;
using DAL;
using DAL.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace PresentationLayer.App_Start
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers


            container.RegisterType<IBusinessService<seller_products_>, SellerProductReposoitory>();

            // container.RegisterType<IWriteRepositry<Product>,  ProductRepositry>();
            //container.RegisterType<ModelContext, ProductRepositry>();
           // container.RegisterType<IGeneral, UserFile>();

           
            //container.RegisterType<IBusinessService, SellerProductBusiness>();



            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

    }
}