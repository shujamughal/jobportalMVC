using CleanArchitecture.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IJobSeekerService
    {
        public JobSeekerSignUpViewModel GetJobSeekerViewModel();
        public JobSeekerViewModel GetJobSeekerById(int id);
        public Task<bool> AddJobSeeker(JobSeekerSignUpViewModel jobSeekerViewModel);
        public Task<bool> DeleteJobSeeker(int id);
        public Task<bool> UpdateJobSeeker(JobSeekerSignUpViewModel jobSeekerViewModel);
    
    }
}
