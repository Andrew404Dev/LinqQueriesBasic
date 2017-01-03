using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    interface IDataRepository<T>
    {
        List<T> Create();
    }
}
