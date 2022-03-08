using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class JobSeekerRoles:Table
    {
        public int Id { get; set; } = -1;

        [ForeignKey("RolesInfo")]
        public int RoleID { get; set; } = -1;
        public virtual RolesInfo RolesInfo { get; set; } = new RolesInfo();

        public string RoleExperience { get; set; } = "";
        [ForeignKey("JobSeeker")]
        public int JobSeekerID { get; set; } = -1;
        public virtual JobSeeker JobSeeker { get; set; } = new JobSeeker();
    }
}
