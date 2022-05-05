using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IReposoitory<T>
    {
        IEnumerable<T> GetAll();
        bool Edit(List<T> p);
    }
}
