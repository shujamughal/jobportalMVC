using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class JobSeekerSkills:Table
    {
        public int Id { get; set; }

        [ForeignKey("SkillsInfo")]
        public int SkillID { get; set; }
        public virtual SkillsInfo SkillsInfo { get; set; } = new SkillsInfo();

        [ForeignKey("JobSeeker")]
        public int JobSeekerID{ get; set; }
        public virtual JobSeeker JobSeeker { get; set; } = new JobSeeker();

        public string SkillRating { get; set; } = "";

    }
}
