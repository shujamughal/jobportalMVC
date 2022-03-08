using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface IJobSeekerSkillsRepository
    {
        List<JobSeekerSkills> GetJobSeekerSkillsInfo(int jobSeekrId=-1);
        Task<bool> AddJobSeekerSkills(List<JobSeekerSkills> skills, int JobSeekerId);
        Task<bool> UpdateJobSeekerSkills(int jobSeekerId, List<JobSeekerSkills> skills);
        Task<bool> DeleteJobSeekerSkills(int jobSeekerId);

    }
}
