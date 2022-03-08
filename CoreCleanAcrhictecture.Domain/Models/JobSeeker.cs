using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models
{
    public partial class JobSeeker:Table
    {
        public int Id { get; set; }
        public String Name { get; set; } = "";
        public String Email { get; set; } = "";
        public String BestCompanyWorked{ get; set; } = "";
        public String Phone{ get; set; } = "";
        public String ResumePath{ get; set; } = "";


        [ForeignKey("JobCategory")]
        public int JobCategoryId { get; set; } = -1;
        public virtual JobCategory JobCategory{ get; set; } = new JobCategory();//new added


        [ForeignKey("GenderType")]
        public int GenderID{ get; set; } = -1;
        public virtual GenderType GenderType{ get; set; } = new GenderType();//new added
     
        [ForeignKey("CareerLevel")]
        public int CareerLevelId{ get; set; } = -1;
        public virtual CareerLevel CareerLevel{ get; set; } = new CareerLevel();//new added

        [ForeignKey("SalaryRange")]
        public int SalID{ get; set; } = -1;
        public virtual SalaryRange SalaryRange{ get; set; } = new SalaryRange();//new added

        [ForeignKey("CityInfo")]
        public int CityID{ get; set; } = -1;
        public virtual CityInfo CityInfo { get; set; } = new CityInfo();


        [ForeignKey("EducationInstituteInfo")]
        public int EducationInstitueID { get; set; } = -1;
        public virtual EducationInstituteInfo EducationInstituteInfo { get; set; } = new EducationInstituteInfo();

        [ForeignKey("LanguageInfo")]
        public int LangID { get; set; } = 1;
        public virtual LanguageInfo LanguageInfo { get; set; } = new LanguageInfo();


        public string ApplicationUserId { get; set; } 
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
