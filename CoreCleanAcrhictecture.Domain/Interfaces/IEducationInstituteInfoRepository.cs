using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Interfaces
{
    public interface  IEducationInstituteInfoRepository
    {
        List<EducationInstituteInfo> GetEducationInstituteInfos();
        Task<int> AddEducationInstituteInfo(EducationInstituteInfo skillsInfo);
        Task<bool> UpdateEducationInstituteInfo(EducationInstituteInfo skillsInfo);
        Task<bool> DeleteEducationInstituteInfo(int id);

    }
}
