using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IEducationService
    {
        public EducationInstituteInfoViewModel  GetEducationInstituteViewModel();
        public List<EducationInstituteInfoViewModel> GetAllInstitutesInfo();
        public Task<bool> AddEducationInstitute(List<EducationInstituteInfoViewModel> educationInstituteInfoViewModel);
        public Task<bool> DeleteEducationInstitute(int id);
        public Task<bool> UpdateEducationInstitute(EducationInstituteInfoViewModel educationInstituteInfoViewModel);
    }
}