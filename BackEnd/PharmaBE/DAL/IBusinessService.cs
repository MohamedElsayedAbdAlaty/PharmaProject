using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public interface IBusinessService<T>
    {
        IEnumerable<T> GetAll();
        bool Edit( );
    }
}
