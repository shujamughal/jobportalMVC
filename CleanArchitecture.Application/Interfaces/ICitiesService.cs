using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface ICitiesService
    {
        public CityViewModel GetCityViewModel();
        public List<CityViewModel> GetAllCitiesViewModels();
        public Task<bool> AddCities(List<CityViewModel> cityViewModels);
        public Task<bool> DeleteCity(int id);
        public Task<bool> UpdateCity(CityViewModel cityViewModel);
    }
}
