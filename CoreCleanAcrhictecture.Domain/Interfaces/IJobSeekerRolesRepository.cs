using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface IJobSeekerRolesRepository
    {
        List<JobSeekerRoles> GetJobSeekerRolesInfo(int jobSeekerId=-1);
        Task<bool> AddJobSeekerRoles(List<JobSeekerRoles> roles,int JobSeekerId);
        Task<bool> UpdateJobSeekerRoles(int jobSeekerId,List<JobSeekerRoles> roles);
        Task<bool> DeleteJobSeekerRoles(int jobSeekerId);

    }
}
