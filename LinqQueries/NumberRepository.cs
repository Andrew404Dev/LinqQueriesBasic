using System.Collections.Generic;

namespace LinqQueries
{
    public class NumberRepository : IDataRepository<int>
    {
        public List<int> Create()
        {
            return new List<int>() { -10, -2, -23, -324,-5,6,-7,8,0,-12,45,65,4,3,23,-23,25,100,1000,10000,231,43,546,313,345,343,100,-14,-90,-89,-78,-56,-45,-23,-13,113,112,-101,-96,-97,-99,-199,-10000,-102,211,222,70,72,-34 };
        }
    }
}
