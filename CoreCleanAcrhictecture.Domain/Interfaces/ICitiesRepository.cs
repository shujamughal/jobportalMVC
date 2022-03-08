using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface ICitiesRepository
    {
        List<CityInfo> GetCityInfos();
        Task<int> AddCity(CityInfo cityInfo);
        Task<bool> UpdateCityInfo(CityInfo cityInfo);
        Task<bool> DeleteCity(int id);
    }
}
