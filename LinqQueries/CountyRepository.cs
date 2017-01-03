using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqQueries.Model;

namespace LinqQueries
{
    public class CountyRepository : IDataRepository<Country>
    {
        public List<Country> Create()
        {
            return new List<Country>() { new Country() { Id = 321, Name = "Россия" }, new Country() { Id = 123, Name = "США" }, new Country() { Id = 232, Name = "Германия" } };
        }
    }
}
