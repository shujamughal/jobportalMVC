using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models.JobProviderModels
{
    public partial class Job:Table
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public string JobDescription{ get; set; }
        public DateTime JobPostDate { get; set; }
        public DateTime JobDeadlineDate { get; set; }
        public string JobRequrements { get; set; }
        public string JobBenifits{ get; set; }
        
        public String JobDepartment { get; set;}
        public String JobType { get; set;}

        [ForeignKey("GenderType")]
        public int GenderID { get; set; } = -1;
        public virtual GenderType GenderType { get; set; } = new GenderType();//new added

        [ForeignKey("ExperienceInfo")]
        public int ExperienceId{ get; set; } = -1;
        public virtual ExperienceInfo ExperienceInfo { get; set; } = new ExperienceInfo();//new added

        [ForeignKey("SalaryRange")]
        public int SalaryRangeId { get; set; }
        public virtual SalaryRange SalaryRange { get; set; }

        [ForeignKey("CareerLevel")]
        public int CareerLevelId { get; set; } = -1;
        public virtual CareerLevel CareerLevel { get; set; } = new CareerLevel();//new added
        [ForeignKey("JobProvider")]
        public int JobProviderId { get; set; } = -1;
        public virtual JobProvider JobProvider { get; set; } = new JobProvider();//new added

    }
}
