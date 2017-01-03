using System;

namespace LinqQueries.Model
{
    public class City : IComparable
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public long Population { get; set; }

        public int CompareTo(object obj)
        {
           return Population.CompareTo(((City)obj).Population);
        }
    }
}
