using LinqQueries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class CityRepository : IDataRepository<City>
    {
        public List<City> Create()
        {
            return new List<City>() {
                new City() { Id = 1, CountryId = 123, Name = "Нью-Йорк", Population = 8550405 },
                new City() { Id = 2, CountryId = 123, Name = "Лос Анджелес", Population = 3971883 },
                new City() { Id = 3, CountryId = 123, Name = "Чикаго", Population = 2720256 },
                new City() { Id = 4, CountryId = 123, Name = "Хьюстон", Population = 2296224 },
                new City() { Id = 5, CountryId = 123, Name = "Филодельфия", Population = 1567442 },
                new City() { Id = 6, CountryId = 123, Name = "Феникс", Population = 1563025 },
                new City() { Id = 7, CountryId = 123, Name = "Сан Антонио", Population = 1469845 },
                new City() { Id = 8, CountryId = 123, Name = "Сан Диего", Population = 1394928 },
                new City() { Id = 9, CountryId = 123, Name = "Далас", Population = 1300092 },
                new City() { Id = 10, CountryId = 321, Name = "Екатеринбург", Population = 2000000 },
                new City() { Id = 11, CountryId = 321, Name = "Москва", Population = 15000000 },
                new City() { Id = 12, CountryId = 321, Name = "Санктпитербург", Population = 8000000 }
            };
        }
    }
}
