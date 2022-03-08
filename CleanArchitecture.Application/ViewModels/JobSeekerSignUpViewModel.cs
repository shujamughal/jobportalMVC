using CoreCleanAcrhictecture.Domain.Models;
using CoreCleanAcrhictecture.Domain.Models.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels
{
    public class JobSeekerSignUpViewModel
    {
        public JobSeeker JobSeeker { get; set; } = new JobSeeker();
        public JobSeekerRoles[] JobSeekerRoles  = new JobSeekerRoles[10];
        public JobSeekerSkills[] JobSeekerSkills = new JobSeekerSkills[10];
        public string JobSeekerSkillsJson;
        public string JobSeekerRolesJson;

        public RefereeInfo ReferreeInfos{ get; set; } = new RefereeInfo();
        public List<SkillsInfo> AllSkills{ get; set; } = new List<SkillsInfo>();
        public List<RolesInfo> AllRoles{ get; set; } = new List<RolesInfo>();
        public List<CityInfo> AllCities{ get; set; } = new List<CityInfo>();
        public List<CareerLevel> CareerLevels{ get; set; } = new List<CareerLevel>();//new added
        public List<SalaryRange> SalaryRanges{ get; set; } = new List<SalaryRange>();//new added
        public List<JobCategory> JobCategories{ get; set; } = new List<JobCategory>();//new added
        public List<GenderType> GenderTypes{ get; set; } = new List<GenderType>();//new added
        public List<EducationInstituteInfo> AllInstitutes { get; set; } = new List<EducationInstituteInfo>();
        public IFormFile ResumeFile { get; set; }
    }
}
