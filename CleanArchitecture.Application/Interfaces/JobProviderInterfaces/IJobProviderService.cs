using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.ViewModels.JobProviderViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.JobProviderInterfaces
{
    public interface IJobProviderService
    {
        public JobProviderSignUpViewModel GetJobProviderViewModel();
        public JobProviderViewModel GetJobProviderById(int id);
        public JobProvidersListViewModel GetJobProvidersListViewModelByUserId(string userId);
        public JobProvidersListViewModel GetAllJobProvidersListViewModel();
        public Task<bool> AddJobProvider(JobProviderViewModel jobSeekerViewModel);
        public Task<bool> DeleteJobProvider(int id);
        public Task<bool> UpdateJobProvider(JobProviderViewModel jobSeekerViewModel);

    }
}
