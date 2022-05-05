using DAL;
using DAL.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Business
{
    /// <summary>
    /// this class used to manage business for sellerproduct table 
    /// </summary>
    public class SellerProductBusiness : IBusinessService<seller_products_>
    {
        private IReposoitory<seller_products_> _reposoitory;
        private IUploadFile _uploadFile;
        List<UpdateFile> excelData;

        public SellerProductBusiness(IReposoitory<seller_products_> reposoitory,
             IUploadFile uploadFile)
        {
            _reposoitory = reposoitory;
            _uploadFile = uploadFile;
            excelData = new List<UpdateFile>();
        }      
        /// <summary>
        /// used to edit discount column in seller products  
        /// </summary>
        /// <returns>return true if successfully other false</returns>
        public bool Edit()
        {
            try
            {
                //get excel data sheet
                excelData = _uploadFile.GetData();
                if(excelData==null)
                {
                    return false;
                }
                //get sellerproducts  data from database
                var sellerProductsList = _reposoitory.GetAll().ToList();
                foreach (var item in excelData)
                {
                    foreach (var prod in sellerProductsList)
                    {
                        if (item.SellerId == prod.seller_id && item.PhrItem == prod.product_id)
                        {
                            prod.discount = Convert.ToDecimal(item.Discount);
                            break;
                        }
                    }

                }
                //edit table in database
                _reposoitory.Edit(sellerProductsList);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
           
        }

        public IEnumerable<seller_products_> GetAll()
        {
            return _reposoitory.GetAll();
        }
    }
}
