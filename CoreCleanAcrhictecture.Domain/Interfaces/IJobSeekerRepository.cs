using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface IJobSeekerRepository
    {
        List<JobSeeker> GetJobSeekers();
        Task<int> AddJobSeeker(JobSeeker jobSeeker);
        Task<bool> UpdateJobSeeker(JobSeeker jobSeeker);
        Task<bool> DeleteJobSeeker(int id);
    }
}
