using CleanArchitecture.Application.Interfaces.JobProviderInterfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.ViewModels.JobProviderViewModels;
using CoreCleanAcrhictecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Services.JobProviderServices
{
    public class SearchEmployeeService:ISearchEmployeeService
    {
        public IJobSeekerRepository _jobSeekerRepository;
        public ISkillsInfoRepository _skillsInfoRepository;
        public IRolesInfoRepository _rolesInfoRepository;
        public IJobSeekerRolesRepository _jobSeekerRolesRepository;
        public IJobSeekerSkillsRepository _jobSeekerSkillsRepository;
        public IEducationInstituteInfoRepository _educationInstituteInfoRepository;
        public ICitiesRepository _citiesRepository;

        public SearchEmployeeService(IJobSeekerRepository jobSeekerRepository, IJobSeekerSkillsRepository jobSeekerSkillsRepository, IJobSeekerRolesRepository jobSeekerRolesRepository, ISkillsInfoRepository skillsInfoRepository, IRolesInfoRepository rolesInfoRepository, IEducationInstituteInfoRepository educationInstituteInfoRepository, ICitiesRepository citiesRepository)
        {
            _citiesRepository = citiesRepository;
            _jobSeekerRepository = jobSeekerRepository;
            _jobSeekerRolesRepository = jobSeekerRolesRepository;
            _jobSeekerSkillsRepository = jobSeekerSkillsRepository;
            _rolesInfoRepository = rolesInfoRepository;
            _skillsInfoRepository = skillsInfoRepository;
            _educationInstituteInfoRepository = educationInstituteInfoRepository;
        }

        public SearchEmployeeViewModel GetSearchEmployeeViewModel()
        {
            return new SearchEmployeeViewModel
            {
                AllCitiesInfo = _citiesRepository.GetCityInfos(),
                AllEmployeesInfo = _jobSeekerRepository.GetJobSeekers(),
                AllRolesInfo = _rolesInfoRepository.GetRolesInfos(),
                AllSkillsInfo = _skillsInfoRepository.GetSkillsInfos(),
                AllJobSeekerRolesInfo = _jobSeekerRolesRepository.GetJobSeekerRolesInfo(),
                AllJobSeekerSkillsInfo = _jobSeekerSkillsRepository.GetJobSeekerSkillsInfo()
            };
        }

    }
}
