using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMultimediali
{
    internal interface IRepositoryManager
    {
        interface IRepositoryManager<T>
        {
            public List<T> Fetch();
            /*public List<T> GetByPrice(double price)*//*;*/
        }
    }
}
