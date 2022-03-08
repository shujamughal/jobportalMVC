using CoreCleanAcrhictecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels
{
    public class JobSeekerViewModel
    {
        public JobSeeker JobSeeker { get; set; } = new JobSeeker();
        public List<JobSeekerRoles> JobSeekerRoles { get; set; } = new List<JobSeekerRoles>(10);
        public List<JobSeekerSkills> JobSeekerSkills { get; set; } = new List<JobSeekerSkills>(10);
        public List<RefereeInfo> JobSeekerReferees { get; set; } = new List<RefereeInfo>();
        public EducationInstituteInfo JobSeekerInstitute { get; set; }
        public LanguageInfo JobSeekerLang { get; set; }
    }
}
