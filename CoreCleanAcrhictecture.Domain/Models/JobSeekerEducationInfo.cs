using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class JobSeekerEducationInfo:Table
    {
        public int Id { get; set; }

        [ForeignKey("EducationInstituteInfo")]
        public int EducationInstitueID { get; set; }
        public EducationInstituteInfo EducationInstituteInfo{ get; set; }

        [ForeignKey("JobSeeker")]
        public int JobSeekerID { get; set; }
        public virtual JobSeeker JobSeeker { get; set; }

    }
}
