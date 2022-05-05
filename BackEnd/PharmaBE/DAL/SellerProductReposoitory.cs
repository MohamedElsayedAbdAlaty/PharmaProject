using DAL.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
   public class SellerProductReposoitory : IReposoitory<seller_products_>
    {
        DatabaseContext context;

        public SellerProductReposoitory(DatabaseContext _db)
        {
            context = _db;
        }
        /// <summary>
        /// used to edit table sellerproducts with updated data
        /// </summary>
        /// <param name="seller_ProductsList">list of updated data for sellersproducts</param>
        /// <returns>return true if success other false</returns>
        public bool Edit(List<seller_products_> seller_ProductsList)
        {
            try
            {
                context.seller_products_.UpdateRange(seller_ProductsList);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                //todo log step
                return false;
            }
            return true;
        }
        /// <summary>
        /// used to get data of sellers products  table from database
        /// </summary>
        /// <returns>list of data</returns>
        public IEnumerable<seller_products_> GetAll()
        {
            var res = context.seller_products_.ToList();
            return res;

        }
    }
}
