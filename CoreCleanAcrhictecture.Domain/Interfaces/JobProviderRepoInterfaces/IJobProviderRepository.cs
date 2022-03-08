using CoreCleanAcrhictecture.Domain.Models.JobProviderModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces.JobProviderRepoInterfaces
{
    public interface IJobProviderRepository
    {
        List<JobProvider> GetAllJobProviders();
        List<JobProvider> GetAllJobProvidersByUserId(string id);
        JobProvider GetSpecificJobProvider(string userId,int jobProviderid);
        List<Job> GetAllJobs();
        List<Job> GetAllJobsByJobProviderId(int jobProviderId);
    }
}