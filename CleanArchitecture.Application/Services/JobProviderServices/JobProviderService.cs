using CleanArchitecture.Application.Interfaces.JobProviderInterfaces;
using CleanArchitecture.Application.ViewModels.JobProviderViewModels;
using CoreCleanAcrhictecture.Domain.Interfaces;
using CoreCleanAcrhictecture.Domain.Interfaces.JobProviderRepoInterfaces;
using CoreCleanAcrhictecture.Domain.Models.JobProviderModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectiiure.Application.Services.JobProviderServices
{
    public class JobProviderService:IJobProviderService
    {
        public IJobProviderRepository _jobProviderRepository;
        public IEducationInstituteInfoRepository _educationInstituteInfoRepository;
        public ICitiesRepository _citiesRepository;
        public ICRUDDbHelperRepository _CRUDDbHelperRepository;
        public ISkillsInfoRepository _skillsInfoRepository;
        public IRolesInfoRepository _rolesInfoRepository;

        public JobProviderService(ICRUDDbHelperRepository CRUDDbHelperRepository, IJobProviderRepository jobProviderRepository, ISkillsInfoRepository skillsInfoRepository, IRolesInfoRepository rolesInfoRepository, IEducationInstituteInfoRepository educationInstituteInfoRepository, ICitiesRepository citiesRepository)
        {
            _citiesRepository = citiesRepository;
            _jobProviderRepository = jobProviderRepository;
            _rolesInfoRepository = rolesInfoRepository;
            _skillsInfoRepository = skillsInfoRepository;
            _educationInstituteInfoRepository = educationInstituteInfoRepository;
            _CRUDDbHelperRepository = CRUDDbHelperRepository;
        }
        public JobProviderSignUpViewModel GetJobProviderViewModel()
        {
            return new JobProviderSignUpViewModel { JobProvider = new JobProvider() };
        }
        public JobProviderViewModel GetJobProviderById(int id)
        {
            JobProviderViewModel jobProviderViewModel = new JobProviderViewModel();
            jobProviderViewModel.JobProvider = _CRUDDbHelperRepository.Get<JobProvider,int>(id).First();
            return jobProviderViewModel;
        }
        public JobProvidersListViewModel GetJobProvidersListViewModelByUserId(string userId)
        {
            JobProvidersListViewModel jobProvidersList = new JobProvidersListViewModel();
            jobProvidersList.AllJobProviders = _jobProviderRepository.GetAllJobProvidersByUserId(userId);
            return jobProvidersList;
        }
        public JobProvidersListViewModel GetAllJobProvidersListViewModel()
        {
            return new JobProvidersListViewModel { AllJobProviders = _jobProviderRepository.GetAllJobProviders() };
        }

        public async Task<bool> AddJobProvider(JobProviderViewModel jobProviderViewModel)
        {
            int id= await _CRUDDbHelperRepository.Add<JobProvider>(jobProviderViewModel.JobProvider);
            return id > 0 ? true : false;
        }
        public async Task<bool> DeleteJobProvider(int id)
        {
            try
            {
                await _CRUDDbHelperRepository.Delete<JobProvider>(id);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
        }
        public async Task<bool> UpdateJobProvider(JobProviderViewModel jobProviderViewModel)
        {
            try
            {
                await _CRUDDbHelperRepository.Update<JobProvider>(jobProviderViewModel.JobProvider.Id,jobProviderViewModel.JobProvider);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
        }
    }
}