using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels.JobProviderViewModels
{
    public class SearchEmployeeViewModel
    {
        public List<JobSeeker> AllEmployeesInfo = new List<JobSeeker>();
        public List<CityInfo> AllCitiesInfo= new List<CityInfo>();
        public List<SkillsInfo> AllSkillsInfo= new List<SkillsInfo>();
        public List<RolesInfo> AllRolesInfo= new List<RolesInfo>();
        public List<JobSeekerRoles> AllJobSeekerRolesInfo= new List<JobSeekerRoles>();
        public List<JobSeekerSkills> AllJobSeekerSkillsInfo = new List<JobSeekerSkills>();
    }
}
