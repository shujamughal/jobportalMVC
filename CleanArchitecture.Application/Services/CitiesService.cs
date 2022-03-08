using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CoreCleanAcrhictecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services
{
    public class CitiesService:ICitiesService
    {
        ICitiesRepository _citiesRepository;
        public CitiesService(ICitiesRepository citiesRepository)
        {
            _citiesRepository = citiesRepository;
        }
        public CityViewModel GetCityViewModel()
        {
            return new CityViewModel();
        }
        public List<CityViewModel> GetAllCitiesViewModels()
        {
            List<CityViewModel> allCities= new List<CityViewModel>();
            foreach (var city in _citiesRepository.GetCityInfos())
            {
                allCities.Add(new CityViewModel{ CityInfo = city});
            }
            return allCities; ;

        }
        public async Task<bool> AddCities(List<CityViewModel> cityViewModels)
        {
            try
            {
                int count = 0;
                foreach (var city in cityViewModels)
                {
                    int id = await _citiesRepository.AddCity(city.CityInfo);
                    if (id > 0)
                        count++;
                }
                return count == cityViewModels.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        public async Task<bool> DeleteCity(int id)
        {
            return await _citiesRepository.DeleteCity(id);
        }
        public async Task<bool> UpdateCity(CityViewModel cityViewModel)
        {
            try
            {
                return await _citiesRepository.UpdateCityInfo(cityViewModel.CityInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

    }
}
