using CoreCleanAcrhictecture.Domain.Models.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreCleanAcrhictecture.Domain.Models.JobProviderModels
{
    public partial class JobProvider:Table
    {
        public int Id { get; set; }
        public string CompanyName{ get; set; } = "";
        public string CompanyContact{ get; set; } = "";
        public string CompanyEmail{ get; set; } = "";
        public string CompanyWebsite{ get; set; } = "";
        public int TotalNumOfEmployee{ get; set; } = -1;
        public String CompanyLogoPath { get; set; } = "";

        [ForeignKey("Address")]
        public int AddressId{ get; set; } = -1;
        public virtual Address Address{ get; set; } = new Address();//new added
        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
