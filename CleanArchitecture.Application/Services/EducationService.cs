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
    public class EducationService:IEducationService
    {
        public IEducationInstituteInfoRepository _educationInstituteInfoRepository;
       
        public EducationService(IEducationInstituteInfoRepository educationInstituteInfoRepository)
        {
            _educationInstituteInfoRepository = educationInstituteInfoRepository;
        }
        public EducationInstituteInfoViewModel GetEducationInstituteViewModel()
        {
            return new EducationInstituteInfoViewModel();
        }

        public List<EducationInstituteInfoViewModel> GetAllInstitutesInfo()
        {
            List<EducationInstituteInfoViewModel> allInstitutes = new List<EducationInstituteInfoViewModel>();
            foreach(var institute in _educationInstituteInfoRepository.GetEducationInstituteInfos())
            {
                allInstitutes.Add(new EducationInstituteInfoViewModel { EducationInstituteInfo = institute });
            }
            return allInstitutes;
        }
        public async Task<bool> AddEducationInstitute(List<EducationInstituteInfoViewModel> educationInstituteInfoViewModel)
        {
            try
            {
                int count = 0;
                foreach (var institute in educationInstituteInfoViewModel)
                {
                    int id = await _educationInstituteInfoRepository.AddEducationInstituteInfo(institute.EducationInstituteInfo);
                    if (id > 0)
                        count++;
                }
                return count == educationInstituteInfoViewModel.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public async Task<bool> DeleteEducationInstitute(int id)
        {
            return await _educationInstituteInfoRepository.DeleteEducationInstituteInfo(id);
        }
        public async Task<bool> UpdateEducationInstitute(EducationInstituteInfoViewModel educationInstituteInfoViewModel)
        {
            try
            {
                return await _educationInstituteInfoRepository.UpdateEducationInstituteInfo(educationInstituteInfoViewModel.EducationInstituteInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
